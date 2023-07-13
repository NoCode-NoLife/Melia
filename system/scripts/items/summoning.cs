using System;
using System.Security.Policy;
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

		var monster = CreateMonster(monsterData.Id, MonsterType.NPC, "BasicMonster", character);
		monster.Components.Get<AiComponent>()?.Script.SetMaster(character);

		character.Map.AddMonster(monster);

		character.Variables.Perm.SetInt("Melia.OrbSummon.MonsterId", monsterData.Id);
		character.Variables.Perm.Set("Melia.OrbSummon.DisappearTime", monster.DisappearTime);

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

		return ItemUseResult.Okay;
	}

	[On("PlayerReady")]
	public void OnPlayerReady(object sender, PlayerEventArgs args)
	{
		if (!ZoneServer.Instance.Conf.World.BlueOrbFollowWarp)
			return;

		var character = args.Character;

		if (!character.Variables.Perm.TryGet<DateTime>("Melia.OrbSummon.DisappearTime", out var disappearTime))
			return;

		if (DateTime.Now > disappearTime)
			return;

		if (!character.Variables.Perm.TryGetInt("Melia.OrbSummon.MonsterId", out var monsterClassId))
			return;

		var monster = CreateMonster(monsterClassId, MonsterType.NPC, "BasicMonster", character);
		monster.Components.Get<AiComponent>()?.Script.SetMaster(character);
		monster.DisappearTime = disappearTime;

		character.Map.AddMonster(monster);
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
}
