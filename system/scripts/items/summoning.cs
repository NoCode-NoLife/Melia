using System;
using Melia.Shared.L10N;
using Melia.Shared.Scripting;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Items;
using Yggdrasil.Util;

public class SummoningItemScripts : GeneralScript
{
	[ScriptableFunction]
	public ItemUseResult SCR_USE_SUMMONORB_FRIEND(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var monsterClassName = strArg;
		if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassName, out var monsterData))
		{
			character.ServerMessage(Localization.Get("Summoning the monster failed."));
			return ItemUseResult.Fail;
		}

		// If the pet system is on and you try to resummon the same monster,
		// it desummons it, otherwise we summon the new monster and desummon
		// the old one. If the pet system is not enabled using an orb for a
		// monster that's already out fails so you don't waste the orb.
		if (character.Variables.Perm.TryGetInt("Melia.BlueOrbSummon.MonsterId", out var monsterClassId))
		{
			if (monsterData.Id == monsterClassId)
			{
				if (ZoneServer.Instance.Conf.World.BlueOrbPetSystem)
				{
					RemoveBlueOrbSummon(character);
					ResetBlueOrbVariables(character);
					return ItemUseResult.OkayNotConsumed;
				}
				else
				{
					character.ServerMessage(Localization.Get("This monster is already summoned."));
					return ItemUseResult.OkayNotConsumed;
				}
			}
		}

		var monster = CreateMonster(monsterData.Id, MonsterType.NPC, "BasicMonster", character);
		monster.Components.Get<AiComponent>()?.Script.SetMaster(character);
		character.Map.AddMonster(monster);

		character.Variables.Perm.SetInt("Melia.BlueOrbSummon.MonsterId", monsterData.Id);

		if (ZoneServer.Instance.Conf.World.BlueOrbPetSystem)
			return ItemUseResult.OkayNotConsumed;

		character.Variables.Perm.Set("Melia.BlueOrbSummon.DisappearTime", monster.DisappearTime);
		return ItemUseResult.Okay;
	}

	[ScriptableFunction]
	public ItemUseResult SCR_USE_SUMMONORB_ENEMY(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var monsterClassName = strArg;
		if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassName, out var monsterData))
		{
			character.ServerMessage(Localization.Get("Summoning the monster failed."));
			return ItemUseResult.Fail;
		}

		var monster = CreateMonster(monsterData.Id, MonsterType.Mob, "BasicMonster", character);
		character.Map.AddMonster(monster);

		var worldconf = ZoneServer.Instance.Conf.World;
		monster.PossiblyBecomeRare(worldconf.RedOrbJackpotRate, worldconf.RedOrbEliteRate);

		return ItemUseResult.Okay;
	}

	[On("PlayerReady")]
	public void OnPlayerReady(object sender, PlayerEventArgs args)
	{
		var character = args.Character;

		if (!character.Variables.Perm.TryGetInt("Melia.BlueOrbSummon.MonsterId", out var monsterClassId))
			return;

		// If follow warp is not enabled, your monster is released from you
		// when you leave a map, functionally causing the master to forget
		// about it and be able to summon another monster.
		if (!ZoneServer.Instance.Conf.World.BlueOrbFollowWarp)
		{
			ResetBlueOrbVariables(character);
			return;
		}

		// If follow warp is on, but the monster's disappear time passed
		// during the warp, we don't resummon it and instead clean it up
		// here.
		if (character.Variables.Perm.TryGet<DateTime>("Melia.BlueOrbSummon.DisappearTime", out var disappearTime))
		{
			if (DateTime.Now > disappearTime)
			{
				ResetBlueOrbVariables(character);
				return;
			}
		}

		var monster = CreateMonster(monsterClassId, MonsterType.NPC, "BasicMonster", character);
		monster.Components.Get<AiComponent>()?.Script.SetMaster(character);

		if (character.Variables.Perm.TryGet<DateTime>("Melia.BlueOrbSummon.DisappearTime", out disappearTime))
			monster.DisappearTime = disappearTime;

		character.Map.AddMonster(monster);
	}

	[On("EntityKilled")]
	public void OnEntityKilled(object sender, CombatEventArgs args)
	{
		// If a summon died, clear the variables from the master

		var target = args.Target;
		var master = target.Components.Get<AiComponent>()?.Script.GetMaster();

		if (master is Character masterCharacter)
			ResetBlueOrbVariables(masterCharacter);
	}

	[On("MonsterDisappears")]
	public void OnMonsterDisappears(object sender, MonsterEventArgs args)
	{
		// If this was a blue orb summon that expired due to the time
		// running out (rather than dying), remove the variables from
		// the summoner

		var target = args.Monster;
		if (target is Mob mob)
		{
			var master = mob.Components.Get<AiComponent>()?.Script.GetMaster();

			if (master is Character masterCharacter && !mob.IsDead)
				ResetBlueOrbVariables(masterCharacter);
		}
	}

	/// <summary>
	/// Creates the monster with the given parameters but doesn't spawn it.
	/// </summary>
	/// <param name="monsterClassId">The id of the monster to spawn.</param>
	/// <param name="monsterType">The monster's type.</param>
	/// <param name="aiName">The name of the AI to use for the monster.</param>
	/// <param name="itemUser">The character that spawned the monster, used as reference for position and property overrides.</param>
	/// <returns></returns>
	private static Mob CreateMonster(int monsterClassId, MonsterType monsterType, string aiName, Character itemUser)
	{
		var pos = GetRandomSpawnPosition(itemUser);

		var monster = new Mob(monsterClassId, monsterType);
		monster.Position = itemUser.Position;

		if (!ZoneServer.Instance.Conf.World.BlueOrbPetSystem || monsterType == MonsterType.Mob)
			monster.DisappearTime = DateTime.Now + TimeSpan.FromSeconds(180);

		if (itemUser.Map.TryGetPropertyOverrides(monsterClassId, out var propertyOverrides))
			monster.ApplyOverrides(propertyOverrides);

		monster.Components.Add(new MovementComponent(monster));
		monster.Components.Add(new AiComponent(monster, aiName));

		return monster;
	}

	/// <summary>
	/// Returns a random spawn position near the character.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	private static Position GetRandomSpawnPosition(Character character)
	{
		var rnd = RandomProvider.Get();
		var pos = character.Position;

		for (var i = 0; i < 10; ++i)
		{
			var rndPos = pos.GetRandomInRange2D(25, rnd);
			if (character.Map.Ground.TryGetHeightAt(rndPos, out var height))
			{
				pos = rndPos;
				pos.Y = height;
				break;
			}
		}

		return pos;
	}

	/// <summary>
	/// Removes the variables associated with the character's blue orb
	/// summon. This does not affect a potentially active summon.
	/// </summary>
	/// <param name="character"></param>
	private void ResetBlueOrbVariables(Character character)
	{
		character.Variables.Perm.Remove("Melia.BlueOrbSummon.MonsterId");
		character.Variables.Perm.Remove("Melia.BlueOrbSummon.DisappearTime");
	}

	/// <summary>
	/// Removes the character's blue orb summon if one is active.
	/// </summary>
	/// <param name="character"></param>
	private void RemoveBlueOrbSummon(Character character)
	{
		// TODO: Improve once we keep better track of masters and followers.
		var monster = character.Map.GetMonster(a => a is Mob mob && mob.Components.Get<AiComponent>()?.Script.GetMaster() == character);
		monster?.Map.RemoveMonster(monster);
	}
}
