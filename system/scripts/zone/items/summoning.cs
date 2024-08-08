using System;
using Melia.Shared.L10N;
using Melia.Shared.Scripting;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Items;
using Yggdrasil.Util;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.Skills;
using Melia.Zone.Network;

public class SummoningItemScripts : GeneralScript
{
	private const bool OrbPetsScaleToLevel = true;

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
				RemoveBlueOrbSummon(character);
				ResetBlueOrbVariables(character);
				return ItemUseResult.OkayNotConsumed;
			}
			else
			{
				RemoveBlueOrbSummon(character);
				ResetBlueOrbVariables(character);
			}
		}

		var monster = CreateMonster(monsterData.Id, MonsterType.NPC, "BasicMonster", character);
		monster.Components.Get<AiComponent>()?.Script.SetMaster(character);
		monster.Vars.SetString("Melia.MinionType", "BlueOrb");
		character.Map.AddMonster(monster);

		if (OrbPetsScaleToLevel)
			ScaleMobToLevel(monster, character.Level);

		character.Variables.Perm.SetInt("Melia.BlueOrbSummon.MonsterId", monsterData.Id);

		ApplyBlueOrbBuff(character, monsterData.Id);

		return ItemUseResult.OkayNotConsumed;
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

		if (character.Variables.Perm.TryGetInt("Melia.RedOrbSummon.MonsterId", out var monsterClassId))
		{
			if (monsterData.Id == monsterClassId)
			{
				RemoveRedOrbSummon(character);
				ResetRedOrbVariables(character);
				return ItemUseResult.OkayNotConsumed;
			}
			else
			{
				RemoveRedOrbSummon(character);
				ResetRedOrbVariables(character);
			}
		}

		var monster = CreateMonster(monsterData.Id, MonsterType.NPC, "BasicMonster", character);
		monster.Components.Get<AiComponent>()?.Script.SetMaster(character);
		monster.Vars.SetString("Melia.MinionType", "RedOrb");
		SetRedOrbExtraSkill(monster);


		character.Map.AddMonster(monster);
		if (OrbPetsScaleToLevel)
			ScaleMobToLevel(monster, character.Level);

		character.Variables.Perm.SetInt("Melia.RedOrbSummon.MonsterId", monsterData.Id);

		return ItemUseResult.OkayNotConsumed;
	}

	[On("PlayerReady")]
	public void OnPlayerReady(object sender, PlayerEventArgs args)
	{
		var character = args.Character;

		if (character.Variables.Perm.TryGetInt("Melia.BlueOrbSummon.MonsterId", out var blueMonsterClassId))
		{
			var monster = CreateMonster(blueMonsterClassId, MonsterType.NPC, "BasicMonster", character);
			monster.Components.Get<AiComponent>()?.Script.SetMaster(character);
			monster.Vars.SetString("Melia.MinionType", "BlueOrb");
			character.Map.AddMonster(monster);
			if (OrbPetsScaleToLevel)
				ScaleMobToLevel(monster, character.Level);
		}

		if (character.Variables.Perm.TryGetInt("Melia.RedOrbSummon.MonsterId", out var redMonsterClassId))
		{
			var monster = CreateMonster(redMonsterClassId, MonsterType.NPC, "BasicMonster", character);
			monster.Components.Get<AiComponent>()?.Script.SetMaster(character);
			SetRedOrbExtraSkill(monster);
			monster.Vars.SetString("Melia.MinionType", "RedOrb");
			character.Map.AddMonster(monster);
			if (OrbPetsScaleToLevel)
				ScaleMobToLevel(monster, character.Level);
		}
	}

	[On("EntityKilled")]
	public void OnEntityKilled(object sender, CombatEventArgs args)
	{
		// If a summon died, clear the variables from the master

		var target = args.Target;
		var master = target.Components.Get<AiComponent>()?.Script.GetMaster();

		if (master is Character masterCharacter && target is Mob mob)
		{
			if (mob.Vars.GetString("Melia.MinionType") == "BlueOrb")
				ResetBlueOrbVariables(masterCharacter);
			if (mob.Vars.GetString("Melia.MinionType") == "RedOrb")
				ResetRedOrbVariables(masterCharacter);
		}
	}

	[On("MonsterDisappears")]
	public void OnMonsterDisappears(object sender, MonsterEventArgs args)
	{
		// If this was an orb summon that expired due to the time
		// running out (rather than dying), remove the variables from
		// the summoner

		var target = args.Monster;
		if (target is Mob mob)
		{
			var master = mob.Components.Get<AiComponent>()?.Script.GetMaster();

			if (master is Character masterCharacter)
			{
				if (mob.Vars.GetString("Melia.MinionType") == "BlueOrb")
					ResetBlueOrbVariables(masterCharacter);
				if (mob.Vars.GetString("Melia.MinionType") == "RedOrb")
					ResetRedOrbVariables(masterCharacter);
			}
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
	/// summon. This should not be done before removing the active summon.
	/// </summary>
	/// <param name="character"></param>
	private void ResetBlueOrbVariables(Character character)
	{
		if (!character.Variables.Perm.Has("Melia.BlueOrbSummon.MonsterId"))
			return;

		RemoveBlueOrbBuff(character, character.Variables.Perm.GetInt("Melia.BlueOrbSummon.MonsterId"));

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
		if (!character.Variables.Perm.TryGetInt("Melia.BlueOrbSummon.MonsterId", out var monsterId))
			return;
		var monster = character.Map.GetMonster(a => a is Mob mob && mob.Data.Id == monsterId && mob.Components.Get<AiComponent>()?.Script.GetMaster() == character);
		monster?.Map.RemoveMonster(monster);		
	}

	/// <summary>
	/// Applies a Blue Orb monster's buff to the master
	/// </summary>
	/// <param name="master"></param>
	/// <param name="mobId"></param>
	private void ApplyBlueOrbBuff(Character master, int mobId)
	{
		// TODO: This needs to be read from a database, this is just a placeholder

		var mobData = ZoneServer.Instance.Data.MonsterDb.Find(mobId);

		if (mobData == null)
			return;

		switch (mobData.Race)
		{
			case RaceType.Forester:
			{
				master.Properties.Modify(PropertyName.MATK_RATE_BM, 0.05f);
				break;
			}
			case RaceType.Widling:
			{
				master.Properties.Modify(PropertyName.PATK_RATE_BM, 0.05f);
				break;
			}
			case RaceType.Paramune:
			{
				master.Properties.Modify(PropertyName.DEF_RATE_BM, 0.05f);
				break;
			}
			case RaceType.Klaida:
			{
				master.Properties.Modify(PropertyName.MHP_RATE_BM, 0.05f);
				break;
			}
			case RaceType.Velnias:
			{
				master.Properties.Modify(PropertyName.MATK_RATE_BM, 0.05f);
				break;
			}
		}

		Send.ZC_OBJECT_PROPERTY(master);
	}

	/// <summary>
	/// Removes a Blue Orb monster's buff from the master
	/// </summary>
	/// <param name="master"></param>
	/// <param name="mobId"></param>
	private void RemoveBlueOrbBuff(Character master, int mobId)
	{
		// TODO: This needs to be read from a database, this is just a placeholder

		var mobData = ZoneServer.Instance.Data.MonsterDb.Find(mobId);

		if (mobData == null)
			return;

		switch (mobData.Race)
		{
			case RaceType.Forester:
			{
				master.Properties.Modify(PropertyName.MATK_RATE_BM, -0.05f);
				break;
			}
			case RaceType.Widling:
			{
				master.Properties.Modify(PropertyName.PATK_RATE_BM, -0.05f);
				break;
			}
			case RaceType.Paramune:
			{
				master.Properties.Modify(PropertyName.DEF_RATE_BM, -0.05f);
				break;
			}
			case RaceType.Klaida:
			{
				master.Properties.Modify(PropertyName.MHP_RATE_BM, -0.05f);
				break;
			}
			case RaceType.Velnias:
			{
				master.Properties.Modify(PropertyName.MATK_RATE_BM, -0.05f);
				break;
			}
		}

		Send.ZC_OBJECT_PROPERTY(master);
	}

	/// <summary>
	/// Removes the variables associated with the character's red orb
	/// summon. This should not be done before removing the active summon.
	/// </summary>
	/// <param name="character"></param>
	private void ResetRedOrbVariables(Character character)
	{
		character.Variables.Perm.Remove("Melia.RedOrbSummon.MonsterId");
		character.Variables.Perm.Remove("Melia.RedOrbSummon.DisappearTime");
	}

	/// <summary>
	/// Removes the character's blue orb summon if one is active.
	/// </summary>
	/// <param name="character"></param>
	private void RemoveRedOrbSummon(Character character)
	{
		// TODO: Improve once we keep better track of masters and followers.
		if (!character.Variables.Perm.TryGetInt("Melia.RedOrbSummon.MonsterId", out var monsterId))
			return;
		var monster = character.Map.GetMonster(a => a is Mob mob && mob.Data.Id == monsterId && mob.Components.Get<AiComponent>()?.Script.GetMaster() == character);
		monster?.Map.RemoveMonster(monster);
	}

	/// <summary>
	/// Sets a red orb monster's extra skill
	/// </summary>
	/// <param name="mob"></param>
	private void SetRedOrbExtraSkill(Mob mob)
	{
		// TODO: This needs to be read from a database, this is just a placeholder
		switch (mob.Data.Race)
		{
			case RaceType.Forester:
			{
				mob.Vars.SetInt("Melia.Mob.ExtraSkill", (int)SkillId.Cleric_Heal);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillLevel", 1);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillUseRate", 20);
				break;
			}
			case RaceType.Widling:
			{
				mob.Vars.SetInt("Melia.Mob.ExtraSkill", (int)SkillId.Highlander_CrossCut);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillLevel", 1);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillUseRate", 40);
				break;
			}
			case RaceType.Paramune:
			{
				mob.Vars.SetInt("Melia.Mob.ExtraSkill", (int)SkillId.Wizard_EarthQuake);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillLevel", 1);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillUseRate", 30);
				break;
			}
			case RaceType.Klaida:
			{
				mob.Vars.SetInt("Melia.Mob.ExtraSkill", (int)SkillId.Wizard_Lethargy);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillLevel", 1);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillUseRate", 30);
				break;
			}
			case RaceType.Velnias:
			{
				mob.Vars.SetInt("Melia.Mob.ExtraSkill", (int)SkillId.Wizard_EnergyBolt);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillLevel", 1);
				mob.Vars.SetInt("Melia.Mob.ExtraSkillUseRate", 50);
				break;
			}
		}
	}


	/// <summary>
	/// Scales the monster's stats based on a target level, mostly for
	/// use with pets.
	/// </summary>
	/// <remarks>
	/// Currently using 2% per level as an approximate level of power.
	/// </remarks>
	public void ScaleMobToLevel(Mob mob, int targetLevel)
	{
		var mobProperties = mob.Properties;

		var currentLevel = mobProperties.GetFloat(PropertyName.Level);

		if (targetLevel == currentLevel)
			return;

		var mobData = mob.Data;

		var levelDifferential = Math.Abs(targetLevel - currentLevel);
		var statMultiplier = 1f;

		// We use the power function so the stat boosts are boosted cumulatively, this
		// makes a big difference when the level differential is high.
		if (targetLevel > currentLevel)
			statMultiplier = (float)Math.Pow(1.02f, levelDifferential);

		if (targetLevel < currentLevel)
			statMultiplier = (float)Math.Pow(0.98f, levelDifferential);

		// Need to subtract 1 because the modify method affects stats additively.
		statMultiplier--;

		// Have to remove the existing level because it's unchangeable
		mobProperties.Remove(PropertyName.Level);
		mobProperties.SetFloat(PropertyName.Level, targetLevel);
		mobProperties.Modify(PropertyName.MHP_BM, mobData.Hp * statMultiplier);
		mobProperties.Modify(PropertyName.MSP_BM, mobData.Sp * statMultiplier);
		mobProperties.Modify(PropertyName.PATK_BM, mobData.PhysicalAttackMin * statMultiplier);
		mobProperties.Modify(PropertyName.MATK_BM, mobData.MagicalAttackMin * statMultiplier);
		mobProperties.Modify(PropertyName.DEF_BM, mobData.PhysicalDefense * statMultiplier);
		mobProperties.Modify(PropertyName.MDEF_BM, mobData.MagicalDefense * statMultiplier);
		mobProperties.Modify(PropertyName.DR_BM, mobData.DodgeRate * statMultiplier);
		mobProperties.Modify(PropertyName.HR_BM, mobData.HitRate * statMultiplier);
		mobProperties.Modify(PropertyName.CRTDR_BM, mobData.CritDodgeRate * statMultiplier);
		mobProperties.Modify(PropertyName.CRTHR_BM, mobData.CritHitRate * statMultiplier);
		mobProperties.Modify(PropertyName.CRTATK_BM, mobData.CritAttack * statMultiplier);
		mobProperties.Modify(PropertyName.BLK_BM, mobData.BlockRate * statMultiplier);
		mobProperties.Modify(PropertyName.BLK_BREAK_BM, mobData.BlockBreakRate * statMultiplier);
	}
}
