using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;

namespace Melia.Zone.Skills.Handlers.Monsters
{
	[SkillHandler(SkillId.Monk_PalmStrike)]
	public class Monk_PalmStrike : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(150);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Monk_1InchPunch)]
	public class Monk_1InchPunch : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_Ballista_Skill_1)]
	public class Mon_pcskill_Ballista_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_Barong_Skill_1)]
	public class Mon_pcskill_Barong_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Giltine_Skill_1)]
	public class Mon_pc_summon_boss_Giltine_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Giltine_Skill_3, SkillId.Mon_Interaction_orsha_catapult_Skill_2, SkillId.Mon_BW_eye_Skill_1, SkillId.Mon_BW_boss_Skiaclipse_Skill_8, SkillId.Mon_BW_boss_Misrus_Skill_4, SkillId.Mon_BW_boss_Vasilissa_Skill_9, SkillId.Mon_BW_boss_Vasilissa_Skill_11, SkillId.Mon_BW_boss_upinis_Skill_1, SkillId.Mon_BW_boss_upinis_Skill_6, SkillId.Mon_BW_boss_upinis_Skill_7, SkillId.Mon_BW_boss_upinis_Skill_9, SkillId.Mon_BW_boss_Slogutis_Skill_5, SkillId.Mon_RE_boss_lecifer_Skill_6, SkillId.Mon_RE_boss_lecifer_Skill_8, SkillId.Mon_RE_boss_lecifer_Skill_9, SkillId.Mon_RE_boss_lecifer_Skill_10, SkillId.Mon_RE_boss_zawra_Skill_5, SkillId.Mon_RE_boss_zawra_Skill_9, SkillId.Mon_RE_boss_zawra_Skill_10, SkillId.Mon_RE_boss_gresmetruth_Skill_2, SkillId.Mon_RE_boss_gresmetruth_Skill_4, SkillId.Mon_RE_boss_gresmetruth_Skill_5, SkillId.Mon_RE_boss_gresmetruth_Skill_6, SkillId.Mon_RE_boss_gresmetruth_Skill_8, SkillId.Mon_RE_boss_gresmetruth_Skill_9, SkillId.Mon_RE_boss_gresmetruth_Skill_10, SkillId.Mon_RE_boss_marnoks_Skill_4, SkillId.Mon_RE_boss_naktis_Skill_4, SkillId.Mon_RE_boss_goblin_warrior_blue_Skill_4, SkillId.Mon_RE_boss_naktis_field_Skill_4, SkillId.Mon_event_boss_lucy_Skill_5, SkillId.Mon_weekly_boss_roze_Skill_1, SkillId.Mon_weekly_boss_roze_Skill_8, SkillId.Mon_weekly_boss_roze_Skill_9, SkillId.Mon_weekly_boss_roze_Skill_10, SkillId.Mon_weekly_boss_upinis_Skill_1, SkillId.Mon_weekly_boss_upinis_Skill_4, SkillId.Mon_weekly_boss_upinis_Skill_8, SkillId.Mon_weekly_boss_upinis_Skill_9, SkillId.Mon_weekly_boss_upinis_Skill_12, SkillId.Mon_weekly_boss_slogutis_Skill_4, SkillId.Mon_weekly_boss_slogutis_Skill_9, SkillId.Mon_weekly_boss_spreader_Skill_2, SkillId.Mon_weekly_boss_falouros_Skill_1, SkillId.Mon_weekly_boss_falouros_Skill_8, SkillId.Mon_weekly_boss_falouros_Skill_9, SkillId.Mon_leader_flammidus_Skill_4, SkillId.Mon_leader_madon_maiden_Skill_2, SkillId.Mon_leader_madon_maiden_Skill_3, SkillId.Mon_leader_madon_maiden_Skill_4, SkillId.Mon_leader_madon_maiden_Skill_5, SkillId.Mon_leader_darbas_smasher_Skill_2, SkillId.Mon_leader_darbas_smasher_Skill_3, SkillId.Mon_leader_bleakferret_prey_Skill_1, SkillId.Mon_leader_bleakferret_prey_Skill_2, SkillId.Mon_leader_bleakferret_prey_Skill_4, SkillId.Mon_leader_bleakferret_prey_Skill_5, SkillId.Mon_leader_blackdevilglove_Skill_3, SkillId.Mon_leader_blackdevilglove_Skill_5, SkillId.Mon_leader_liepsna_firebug_Skill_2, SkillId.Mon_leader_liepsna_firebug_Skill_3, SkillId.Mon_leader_liepsna_firebug_Skill_4, SkillId.Mon_leader_saugumas_executor_Skill_4, SkillId.Mon_leader_saugumas_executor_Skill_5, SkillId.Mon_demonlair_goblin_sweeper_Skill_2, SkillId.Mon_demonlair_bleakferret_cannon_Skill_1, SkillId.Mon_demonlair_transmutation_merchant_Skill_2, SkillId.Mon_demonlair_bleakferret_scout_Skill_1, SkillId.Mon_demonlair_bleakferret_scout_Skill_2, SkillId.Mon_demonlair_bleakferret_prey_Skill_1, SkillId.Mon_demonlair_bleakferret_prey_Skill_2, SkillId.Mon_boss_Avataras_Renewal_Skill_19, SkillId.Mon_GM_BowerKeeper_Destroyer_Skill_3, SkillId.Mon_GM_BowerKeeper_Destroyer_Skill_5, SkillId.Mon_GM_boss_BowerKeeper_Skill_3, SkillId.Mon_GM_boss_BowerKeeper_Skill_5, SkillId.Mon_GM_boss_BlackDevilglove_Skill_3, SkillId.Mon_GM_boss_BlackDevilglove_Skill_5, SkillId.Mon_M_boss_poata_Skill_4, SkillId.Mon_M_boss_Glass_mole_Skill_4, SkillId.Mon_boss_Shnayim_Skill_4, SkillId.Mon_boss_Goblin_Warrior_Skill_4, SkillId.Mon_boss_Goblin_Warrior_red_Skill_4, SkillId.Mon_boss_cactusvel_Skill_4, SkillId.Mon_boss_moa_Skill_5, SkillId.Mon_boss_woodhoungan_Skill_3, SkillId.Mon_boss_woodhoungan_Skill_4, SkillId.Mon_boss_woodhoungan_Skill_5, SkillId.Mon_boss_RingCrawler_Skill_5, SkillId.Mon_boss_Pyroego_Skill_5, SkillId.Mon_boss_Yeti_Skill_2, SkillId.Mon_pc_summon_Riteris_Skill_2, SkillId.Mon_boss_velnewt_Skill_3, SkillId.Mon_Chafperor_mage_Skill_2, SkillId.Mon_Flamme_mage_Skill_2, SkillId.Mon_boss_Zawra_Skill_5, SkillId.Mon_F_boss_Marnoks_Skill_5, SkillId.Mon_M_boss_Shnayim_Skill_4, SkillId.Mon_ET_boss_Pyroego_Skill_5, SkillId.Mon_pc_summon_boss_Pyroego_Skill_3, SkillId.Mon_aklasia_Skill_3, SkillId.Mon_goblin2_wand1_Skill_2, SkillId.Mon_GRB_boss_Chapparition_Skill_3, SkillId.Mon_GMB_boss_woodspirit_green_Skill_4, SkillId.Mon_GMB_boss_Moyabruka_Skill_2, SkillId.Mon_boss_flowertree_Skill_2, SkillId.Mon_Gagoyle_purple_Skill_6, SkillId.Mon_pc_summon_boss_Marnoks_Skill_2, SkillId.Mon_GFB_boss_PantoRex_Skill_8, SkillId.Mon_F_boss_solcomm_Skill_6, SkillId.Mon_Lotuscat_Skill_2, SkillId.Mon_Yishoneer_Skill_2, SkillId.Mon_vespera_Skill_2, SkillId.Mon_uniq_id_boss_Asiomage_Skill_7, SkillId.Mon_uniq_boss_Mandara_Skill_2, SkillId.Mon_boss_Wastrel_Red_Skill_1, SkillId.Mon_boss_Wastrel_Skill_2, SkillId.Mon_uniq_id_skill_wastrelobj_Skill_1, SkillId.Mon_boss_AmissDog_Skill_3, SkillId.Mon_boss_AmissDog_Skill_4, SkillId.Mon_boss_AmissDog_Skill_5, SkillId.Mon_boss_Meskalord_Skill_2, SkillId.Mon_boss_FealtyHound_Skill_4, SkillId.Mon_boss_madon_maiden_Skill_2, SkillId.Mon_boss_madon_maiden_Skill_3, SkillId.Mon_boss_madon_maiden_Skill_4, SkillId.Mon_boss_madon_maiden_Skill_5, SkillId.Mon_uniq_id_boss_ProddedHorse_Skill_6, SkillId.Mon_ignas_summon_vesperia_Skill_3, SkillId.Mon_uniq_id_boss_ignas_Skill_10, SkillId.Mon_Spider_Skill_2, SkillId.Mon_uniq_id_boss_Tantaliser_Skill_2, SkillId.Mon_uniq_id_boss_Tantaliser_Skill_4, SkillId.Mon_uniq_id_boss_Tantaliser_Skill_6, SkillId.Mon_ghosbebe_Skill_2, SkillId.Mon_boss_Moringponia_Skill_1, SkillId.Mon_boss_Tantaliser_Skill_2, SkillId.Mon_boss_Tantaliser_Skill_4, SkillId.Mon_boss_Tantaliser_Skill_6, SkillId.Mon_boss_Skiaclipse_Skill_9, SkillId.Mon_boss_Skiaclipse_Skill_10, SkillId.Mon_boss_Skiaclipse_Skill_11, SkillId.Mon_hidden_monster_skiaclipse_Skill_1, SkillId.Mon_Legend_Boss_Skiaclipse_Skill_9, SkillId.Mon_Legend_Boss_Skiaclipse_Skill_10, SkillId.Mon_Legend_Boss_Skiaclipse_Skill_11, SkillId.Mon_Raid_boss_Misrus_Skill_4, SkillId.Mon_Raid_boss_Misrus_Skill_5, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_2, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_4, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_6, SkillId.Mon_Legend_Boss_Tantaliser_Skill_2, SkillId.Mon_Legend_Boss_Tantaliser_Skill_4, SkillId.Mon_Legend_Boss_Tantaliser_Skill_6, SkillId.Mon_Legend_Boss_Skiaclipse_Solo_Skill_9, SkillId.Mon_Legend_Boss_Skiaclipse_Solo_Skill_10, SkillId.Mon_Legend_Boss_Skiaclipse_Solo_Skill_11, SkillId.Mon_boss_Skiaclipse_Solo_Skill_9, SkillId.Mon_boss_Skiaclipse_Solo_Skill_10, SkillId.Mon_boss_Skiaclipse_Solo_Skill_11, SkillId.Mon_hidden_monster_Ancient_02_Skill_1, SkillId.Mon_hidden_monster_Ancient_03_Skill_1, SkillId.Mon_hidden_monster_skiaclipse_solo_Skill_1, SkillId.Mon_ep12_Orc_cannon_Skill_2, SkillId.Mon_ep12_Orc_flag_Skill_2, SkillId.Mon_pc_summon_boss_Tantaliser_Skill_1, SkillId.Mon_weekly_boss_solcom_Skill_6, SkillId.Mon_Uniq_boss_Glacier_Skill_2, SkillId.Mon_Uniq_boss_Glacier_Skill_5, SkillId.Mon_Uniq_boss_Glacier_Skill_9, SkillId.Mon_Uniq_boss_Glacier_Skill_11, SkillId.Mon_FieldRift_pattern_Skill_1, SkillId.Mon_FieldRift_pattern_Skill_2, SkillId.Mon_FieldRift_pattern_Skill_5, SkillId.Mon_FieldRift_pattern_Skill_6, SkillId.Mon_FieldRift_pattern_Skill_7, SkillId.Mon_FieldRift_pattern_Skill_8, SkillId.Mon_Uniq_boss_Pbeta_Skill_2, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_2, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_4, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_6, SkillId.Mon_boss_Vasilissa_Skill_6, SkillId.Mon_boss_Vasilissa_Skill_7, SkillId.Mon_boss_Vasilissa_Skill_8, SkillId.Mon_boss_Vasilissa_Skill_10, SkillId.Mon_boss_Vasilissa_Skill_16, SkillId.Mon_boss_Vasilissa_Skill_17, SkillId.Mon_Uniq_boss_Glacier_Skill_15, SkillId.Mon_Uniq_boss_Pbeta_Skill_11, SkillId.Mon_weekly_boss_Marnoks_Skill_5, SkillId.Mon_F_boss_Skiaclipse_Skill_9, SkillId.Mon_F_boss_Skiaclipse_Skill_10, SkillId.Mon_F_boss_Skiaclipse_Skill_11, SkillId.Mon_Legend_boss_Glacier_Skill_2, SkillId.Mon_Legend_boss_Glacier_Skill_5, SkillId.Mon_Legend_boss_Glacier_Skill_9, SkillId.Mon_Legend_boss_Glacier_Skill_11, SkillId.Mon_Legend_boss_Glacier_Skill_15, SkillId.Mon_Legend_boss_Pbeta_Skill_2, SkillId.Mon_Legend_boss_Pbeta_Skill_11, SkillId.Mon_boss_Irredians_TelHarsha_Skill_2, SkillId.Mon_boss_Irredians_TelHarsha_Skill_5, SkillId.Mon_boss_Irredians_TelHarsha_Skill_8, SkillId.Mon_boss_Irredians_TelHarsha_Skill_10, SkillId.Mon_boss_Irredians_TelHarsha_Skill_12, SkillId.Mon_Legend_boss_Glacier_Skill_16, SkillId.Mon_Legend_boss_Glacier_Skill_17, SkillId.Mon_weekly_boss_Naktis_Skill_4, SkillId.Mon_weekly_boss_Naktis_Skill_5, SkillId.Mon_weekly_boss_lucy_Skill_1, SkillId.Mon_weekly_boss_lucy_Skill_2, SkillId.Mon_weekly_boss_lucy_Skill_4, SkillId.Mon_weekly_boss_lucy_Skill_5, SkillId.Mon_weekly_boss_Tiny_Skill_2, SkillId.Mon_weekly_boss_solcomm_Skill_7, SkillId.Mon_boss_TelHarsha_AmissDog_Skill_1, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_2, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_4, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_6, SkillId.Mon_Uniq_boss_Glacier_Solo_Skill_2, SkillId.Mon_Uniq_boss_Glacier_Solo_Skill_5, SkillId.Mon_Uniq_boss_Glacier_Solo_Skill_9, SkillId.Mon_Uniq_boss_Glacier_Solo_Skill_11, SkillId.Mon_Uniq_boss_Glacier_Solo_Skill_15, SkillId.Mon_Uniq_boss_Pbeta_Solo_Skill_2, SkillId.Mon_Uniq_boss_Pbeta_Solo_Skill_11, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_2, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_5, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_9, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_11, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_15, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_16, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_17, SkillId.Mon_Legend_boss_Pbeta_Solo_Skill_2, SkillId.Mon_Legend_boss_Pbeta_Solo_Skill_11, SkillId.Mon_ep12_bower_guillotine_Skill_2, SkillId.Mon_ep12_raganosis_guardian_Skill_2, SkillId.Mon_boss_BowerKeeper_Skill_3, SkillId.Mon_boss_BowerKeeper_Skill_5, SkillId.Mon_boss_RaganosisCommander_Skill_2, SkillId.Mon_boss_RaganosisCommander_Skill_3, SkillId.Mon_boss_RaganosisCommander_Skill_4, SkillId.Mon_boss_RaganosisCommander_Skill_5, SkillId.Mon_field_boss_Marnoks_Skill_5, SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_2, SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_3, SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_4, SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_5, SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_7, SkillId.Mon_boss_Giltine_Glackuman_minimal_Skill_2, SkillId.Mon_boss_Giltine_Glackuman_minimal_Skill_3, SkillId.Mon_boss_Giltine_Glackuman_minimal_Skill_4, SkillId.Mon_boss_Giltine_Glackuman_minimal_Skill_5, SkillId.Mon_boss_Giltine_Naktis_minimal_Skill_2, SkillId.Mon_boss_Giltine_Naktis_minimal_Skill_3, SkillId.Mon_boss_Giltine_Naktis_minimal_Skill_5, SkillId.Mon_Legend_Boss_Avataras_Skill_19, SkillId.Mon_Legend_Boss_Avataras_Guild_Skill_19, SkillId.Mon_ep13_darbas_loader_Skill_2, SkillId.Mon_ep13_darbas_miner_Skill_2, SkillId.Mon_ep13_biblioteka_keeper_Skill_2, SkillId.Mon_ep13_elgesys_guard_Skill_2, SkillId.Mon_boss_liepsna_firebug_Skill_2, SkillId.Mon_boss_liepsna_firebug_Skill_3, SkillId.Mon_boss_liepsna_firebug_Skill_4, SkillId.Mon_boss_darbas_smasher_Skill_2, SkillId.Mon_boss_darbas_smasher_Skill_3, SkillId.Mon_boss_darbas_smasher_Skill_4, SkillId.Mon_boss_darbas_smasher_Skill_5, SkillId.Mon_boss_saugumas_executor_Skill_4, SkillId.Mon_boss_saugumas_executor_Skill_5, SkillId.Mon_weekly_lapinel_lucy_summon_Skill_3, SkillId.Mon_weekly_lapindion_lucy_summon_Skill_2, SkillId.Mon_Legend_Boss_Avataras_Auto_Skill_19, SkillId.Mon_boss_Mythic_Genmagnus_Skill_1, SkillId.Mon_boss_Mythic_Pyroego_Skill_5, SkillId.Mon_boss_FD_durahan_Skill_2, SkillId.Mon_boss_FD_durahan_Skill_3, SkillId.Mon_boss_FD_durahan_Skill_4, SkillId.Mon_boss_FD_NetherBovine_Skill_2, SkillId.Mon_boss_FD_Riteris_Skill_2, SkillId.Mon_boss_FD_Riteris_Skill_3, SkillId.Mon_boss_FD_Riteris_Skill_4, SkillId.Mon_boss_FD_Marionette_Skill_2, SkillId.Mon_boss_FD_Marionette_Skill_3, SkillId.Mon_boss_FD_succubus_Skill_2, SkillId.Mon_boss_FD_succubus_Skill_3, SkillId.Mon_boss_FD_ginklas_Skill_2, SkillId.Mon_FD_boss_Wastrel_Skill_2, SkillId.Mon_FD_boss_Tantaliser_Skill_2, SkillId.Mon_FD_boss_Tantaliser_Skill_4, SkillId.Mon_FD_boss_Tantaliser_Skill_6, SkillId.Mon_FD_boss_Pbeta_Skill_2, SkillId.Mon_FD_boss_Glacier_Skill_2, SkillId.Mon_boss_Vasilissa_Skill_18, SkillId.Mon_boss_Vasilissa_Skill_20, SkillId.Mon_boss_Vasilissa_Skill_23, SkillId.Mon_boss_Vasilissa_Skill_24, SkillId.Mon_boss_Vasilissa_Skill_26, SkillId.Mon_weekly_boss_Asiomage_Skill_7, SkillId.Mon_weekly_boss_diena_Skill_1, SkillId.Mon_weekly_boss_diena_Skill_3, SkillId.Mon_weekly_boss_diena_Skill_4, SkillId.Mon_weekly_boss_diena_Skill_5, SkillId.Mon_weekly_boss_diena_Skill_6, SkillId.Mon_weekly_boss_diena_Skill_7, SkillId.Mon_boss_RevivalPaulius_Skill_3, SkillId.Mon_boss_RevivalPaulius_Skill_9, SkillId.Mon_boss_RevivalPaulius_Skill_10, SkillId.Mon_ep14_1_npc_pajauta_Skill_3, SkillId.Mon_ep14_1_Bleakferret_Cannon_Skill_1, SkillId.Mon_ep14_1_GresmeRaven_Skill_2, SkillId.Mon_ep14_1_TransmutationMerchant_Skill_2, SkillId.Mon_boss_GresmeTruth_Skill_2, SkillId.Mon_boss_GresmeTruth_Skill_4, SkillId.Mon_boss_GresmeTruth_Skill_5, SkillId.Mon_boss_DelmoreCastleGate_Skill_2, SkillId.Mon_boss_DelmoreCastleGate_Skill_5, SkillId.Mon_boss_DelmoreCastleGate_Skill_7, SkillId.Mon_boss_DelmoreCastleGate_Skill_8, SkillId.Mon_boss_DelmoreCastleGate_Skill_9, SkillId.Mon_boss_DelmoreCastleGate_Skill_10, SkillId.Mon_field_boss_diena_Skill_1, SkillId.Mon_field_boss_diena_Skill_3, SkillId.Mon_field_boss_diena_Skill_4, SkillId.Mon_field_boss_diena_Skill_5, SkillId.Mon_field_boss_diena_Skill_6, SkillId.Mon_field_boss_diena_Skill_7, SkillId.Mon_boss_DelmoreCastleGate_Skill_13, SkillId.Mon_field_boss_solcomm_Skill_7, SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_3, SkillId.Mon_field_boss_Naktis_Skill_4, SkillId.Mon_field_boss_Naktis_Skill_5, SkillId.Mon_boss_Jellyzele_Skill_6, SkillId.Mon_boss_Jellyzele_Skill_9, SkillId.Mon_boss_Jellyzele_Skill_11, SkillId.Mon_boss_Jellyzele_Skill_12, SkillId.Mon_boss_Jellyzele_Skill_20, SkillId.Mon_boss_Jellyzele_Skill_23, SkillId.Mon_boss_Jellyzele_Skill_24, SkillId.Mon_boss_Jellyzele_Skill_25, SkillId.Mon_boss_Jellyzele_Skill_26, SkillId.Mon_boss_Jellyzele_Skill_29, SkillId.Mon_boss_Jellyzele_Skill_30, SkillId.Mon_boss_Jellyzele_Skill_31, SkillId.Mon_ep14_2_Bleakferret_Scout_Skill_1, SkillId.Mon_ep14_2_Bleakferret_Scout_Skill_2, SkillId.Mon_boss_TransmutationSpreader_Q1_Skill_3, SkillId.Mon_boss_TransmutationSpreader_Skill_2, SkillId.Mon_boss_TransmutationSpreader_Skill_9, SkillId.Mon_boss_TransmutationSpreader_Skill_12, SkillId.Mon_boss_Bleakferret_prey_Skill_1, SkillId.Mon_boss_Bleakferret_prey_Skill_2, SkillId.Mon_boss_Bleakferret_prey_Skill_4, SkillId.Mon_boss_Bleakferret_prey_Skill_5, SkillId.Mon_boss_TransmutationSpreader_Skill_19, SkillId.Mon_boss_Falouros_Skill_1, SkillId.Mon_boss_Falouros_Skill_11, SkillId.Mon_boss_Falouros_Skill_13, SkillId.Mon_boss_Falouros_Auto_Skill_1, SkillId.Mon_boss_Falouros_Auto_Skill_11, SkillId.Mon_boss_Falouros_Auto_Skill_13, SkillId.Mon_boss_Falouros_Solo_Skill_1, SkillId.Mon_boss_Falouros_Solo_Skill_11, SkillId.Mon_boss_Falouros_Solo_Skill_13, SkillId.Mon_boss_blackdevilglove_Skill_3, SkillId.Mon_boss_blackdevilglove_Skill_5, SkillId.Mon_boss_Roze_Skill_1, SkillId.Mon_boss_Roze_Skill_7, SkillId.Mon_boss_Roze_Skill_9, SkillId.Mon_boss_Roze_Skill_10, SkillId.Mon_boss_Roze_Skill_11, SkillId.Mon_boss_Roze_Skill_12, SkillId.Mon_boss_Roze_Skill_15, SkillId.Mon_boss_Roze_Auto_Skill_1, SkillId.Mon_boss_Roze_Auto_Skill_7, SkillId.Mon_boss_Roze_Auto_Skill_9, SkillId.Mon_boss_Roze_Auto_Skill_10, SkillId.Mon_boss_Roze_Auto_Skill_11, SkillId.Mon_boss_Roze_Auto_Skill_12, SkillId.Mon_boss_Roze_Auto_Skill_15, SkillId.Mon_boss_Roze_Solo_Skill_1, SkillId.Mon_boss_Roze_Solo_Skill_7, SkillId.Mon_boss_Roze_Solo_Skill_9, SkillId.Mon_boss_Roze_Solo_Skill_10, SkillId.Mon_boss_Roze_Solo_Skill_11, SkillId.Mon_boss_Roze_Solo_Skill_12, SkillId.Mon_boss_Roze_Solo_Skill_15, SkillId.Mon_boss_Roze_Q1_Skill_1, SkillId.Mon_boss_Roze_Q1_Skill_2, SkillId.Mon_boss_Roze_Q1_Skill_5, SkillId.Mon_boss_Roze_Skill_16, SkillId.Mon_boss_Roze_Auto_Skill_16, SkillId.Mon_boss_Roze_Solo_Skill_16, SkillId.Mon_spreader_transform_Skill_2, SkillId.Mon_boss_upinis_Skill_1, SkillId.Mon_boss_upinis_Skill_4, SkillId.Mon_boss_upinis_Skill_9, SkillId.Mon_boss_upinis_Skill_10, SkillId.Mon_boss_upinis_Skill_11, SkillId.Mon_boss_upinis_Skill_12, SkillId.Mon_boss_upinis_Skill_14, SkillId.Mon_boss_upinis_Skill_16, SkillId.Mon_boss_upinis_Skill_17, SkillId.Mon_boss_upinis_Skill_18, SkillId.Mon_boss_upinis_Auto_Skill_1, SkillId.Mon_boss_upinis_Auto_Skill_4, SkillId.Mon_boss_upinis_Auto_Skill_9, SkillId.Mon_boss_upinis_Auto_Skill_10, SkillId.Mon_boss_upinis_Auto_Skill_11, SkillId.Mon_boss_upinis_Auto_Skill_12, SkillId.Mon_boss_upinis_Auto_Skill_14, SkillId.Mon_boss_upinis_Auto_Skill_16, SkillId.Mon_boss_upinis_Auto_Skill_17, SkillId.Mon_boss_upinis_Auto_Skill_18, SkillId.Mon_boss_upinis_Solo_Skill_1, SkillId.Mon_boss_upinis_Solo_Skill_4, SkillId.Mon_boss_upinis_Solo_Skill_9, SkillId.Mon_boss_upinis_Solo_Skill_10, SkillId.Mon_boss_upinis_Solo_Skill_11, SkillId.Mon_boss_upinis_Solo_Skill_12, SkillId.Mon_boss_upinis_Solo_Skill_14, SkillId.Mon_boss_upinis_Solo_Skill_16, SkillId.Mon_boss_upinis_Solo_Skill_17, SkillId.Mon_boss_upinis_Solo_Skill_18, SkillId.Mon_boss_freedungeon_telharsha_Skill_2, SkillId.Mon_boss_freedungeon_telharsha_Skill_3, SkillId.Mon_boss_freedungeon_telharsha_Skill_5, SkillId.Mon_boss_freedungeon_telharsha_Skill_8, SkillId.Mon_boss_freedungeon_telharsha_Skill_9, SkillId.Mon_boss_freedungeon_telharsha_Skill_10, SkillId.Mon_boss_freedungeon_telharsha_Skill_12, SkillId.Mon_boss_freedungeon_telharsha_amissdog_Skill_2, SkillId.Mon_boss_Slogutis_Skill_5, SkillId.Mon_boss_Slogutis_Skill_10, SkillId.Mon_boss_Slogutis_Auto_Skill_5, SkillId.Mon_boss_Slogutis_Auto_Skill_10, SkillId.Mon_boss_Slogutis_Solo_Skill_5, SkillId.Mon_boss_Slogutis_Solo_Skill_10, SkillId.Mon_earring_revivalpaulius_Skill_1, SkillId.Mon_earring_revivalpaulius_Skill_2, SkillId.Mon_earring_revivalpaulius_Skill_5, SkillId.Mon_earring_jellyzele_Skill_2, SkillId.Mon_earring_jellyzele_Skill_4, SkillId.Mon_earring_jellyzele_Skill_5, SkillId.Mon_earring_jellyzele_Skill_7, SkillId.Mon_earring_jellyzele_Skill_9, SkillId.Mon_earring_jellyzele_Skill_10, SkillId.Mon_earring_jellyzele_Skill_11, SkillId.Mon_earring_falouros_Skill_1, SkillId.Mon_earring_upinis_Skill_1, SkillId.Mon_earring_upinis_Skill_4, SkillId.Mon_ep16_2_boss_pyroego_Skill_5, SkillId.Mon_boss_Veliora_Solo_Skill_2, SkillId.Mon_boss_upinis_Q1_Skill_1, SkillId.Mon_boss_upinis_Q1_Skill_2, SkillId.Mon_boss_upinis_Q1_Skill_4, SkillId.Mon_boss_Slogutis_Q1_Skill_2)]
	public class Mon_pc_summon_boss_Giltine_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_npc_CEN_master_Skill_1, SkillId.Mon_ep14_1_npc_Skill_2, SkillId.Mon_weekly_boss_spreader_Skill_4, SkillId.Mon_weekly_boss_spreader_Skill_5, SkillId.Mon_weekly_boss_spreader_Skill_10, SkillId.Mon_boss_Mushcaria_Q2_Skill_4, SkillId.Mon_bumble_green_Skill_2, SkillId.Mon_ArchGargoyle_Skill_2, SkillId.Mon_boss_FD_SwordBallista_Skill_2, SkillId.Mon_weekly_boss_Asiomage_Skill_2, SkillId.Mon_weekly_boss_Asiomage_Skill_4, SkillId.Mon_weekly_boss_Asiomage_Skill_6, SkillId.Mon_ep14_1_kingdomsodier_Skill_1, SkillId.Mon_ep14_1_kingdomsodier_Skill_2, SkillId.Mon_boss_TransmutationSpreader_Q1_Skill_2, SkillId.Mon_boss_TransmutationSpreader_Q1_Skill_4, SkillId.Mon_boss_TransmutationSpreader_Q1_Skill_5, SkillId.Mon_boss_TransmutationSpreader_Skill_4, SkillId.Mon_boss_TransmutationSpreader_Skill_5, SkillId.Mon_boss_TransmutationSpreader_Skill_14, SkillId.Mon_boss_TransmutationSpreader_Skill_15, SkillId.Mon_ep15_1_Goblin_Rider_Skill_2, SkillId.Mon_spreader_transform_Skill_1, SkillId.Mon_earring_spreader_Skill_2)]
	public class Mon_npc_CEN_master_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep14_1_npc_Skill_1)]
	public class Mon_ep14_1_npc_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Interaction_orsha_catapult_Skill_1)]
	public class Mon_Interaction_orsha_catapult_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Interaction_GresmeRaven_Skill_1)]
	public class Mon_Interaction_GresmeRaven_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(50199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(49999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 600f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Interaction_ballista_Skill_1)]
	public class Mon_Interaction_ballista_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 750f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Kerberos_Skill_1)]
	public class Mon_BW_boss_Kerberos_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Kerberos_Skill_2, SkillId.Mon_boss_Kerberos_Skill_2)]
	public class Mon_BW_boss_Kerberos_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Lapedame_Skill_3, SkillId.Mon_RE_boss_zawra_Skill_3, SkillId.Mon_RE_boss_stone_whale_Skill_1, SkillId.Mon_ep16_1_leader_carapace_Skill_4, SkillId.Mon_ep16_1_leader_canceril_Skill_2, SkillId.Mon_leader_rocksodon_Skill_2, SkillId.Mon_leader_flammidus_Skill_3, SkillId.Mon_boss_stone_whale_Skill_1, SkillId.Mon_boss_Ironbaum_Skill_3, SkillId.Mon_Rodelin_Skill_3, SkillId.Mon_M_boss_Golem_gray_Skill_6, SkillId.Mon_M_boss_Golem_gray_Skill_4, SkillId.Mon_boss_stone_whale_Skill_6, SkillId.Mon_boss_Carapace_Skill_4, SkillId.Mon_boss_MagBurk_Skill_5, SkillId.Mon_boss_Drapeliun_Skill_4, SkillId.Mon_boss_Canceril_Skill_2, SkillId.Mon_boss_Golem_Q1_Skill_5, SkillId.Mon_Repusbunny_mage_Skill_2, SkillId.Mon_Elma_Skill_2, SkillId.Mon_PC_summon_Canceril_Skill_1, SkillId.Mon_boss_Rocksodon_Skill_2, SkillId.Mon_boss_Prisoncutter_Skill_4, SkillId.Mon_boss_stonefroster_Skill_2, SkillId.Mon_boss_Flammidus_Skill_3, SkillId.Mon_boss_Zawra_Skill_3, SkillId.Mon_pc_summon_Prisoncutter_Skill_2, SkillId.Mon_pc_summon_Flammidus_Skill_3, SkillId.Mon_ID_boss_Prisoncutter_Skill_4, SkillId.Mon_M_boss_GiantWoodGoblin_Skill_5, SkillId.Mon_M_boss_Ironbaum_Skill_3, SkillId.Mon_ET_Rocksodon_minimal_Skill_3, SkillId.Mon_ET_boss_Flammidus_Skill_3, SkillId.Mon_flamel_Skill_2, SkillId.Mon_ET_boss_Neop_Skill_5, SkillId.Mon_Boss_ebonypawn_Skill_3, SkillId.Mon_mythic_Elma_Skill_2, SkillId.Mon_mythic_boss_Prisoncutter_Skill_4)]
	public class Mon_BW_boss_Lapedame_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Lapedame_Skill_5)]
	public class Mon_BW_boss_Lapedame_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Foculus_Skill_1)]
	public class Mon_BW_boss_Foculus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Foculus_Skill_2)]
	public class Mon_BW_boss_Foculus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_PantoRex_Skill_1)]
	public class Mon_BW_boss_PantoRex_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_torelodeer_Skill_2, SkillId.Mon_BW_boss_torelodeer_Skill_5, SkillId.Mon_BW_boss_aklasprincess_Skill_4, SkillId.Mon_BW_boss_aklasprincess_Skill_5, SkillId.Mon_BW_boss_priest_of_dawn_Skill_2, SkillId.Mon_RE_boss_solcomm_Skill_5, SkillId.Mon_RE_boss_solcomm_Skill_6, SkillId.Mon_RE_boss_solcomm_Skill_8, SkillId.Mon_RE_boss_solcomm_Skill_9, SkillId.Mon_RE_boss_solcomm_Skill_10, SkillId.Mon_RE_boss_nuaelle_Skill_2, SkillId.Mon_RE_boss_nuaelle_Skill_3, SkillId.Mon_RE_boss_nuaelle_Skill_4, SkillId.Mon_RE_boss_nuaelle_Skill_5, SkillId.Mon_RE_boss_froster_lord_Skill_1, SkillId.Mon_RE_boss_froster_lord_Skill_3, SkillId.Mon_panto_Gstaff_Skill_3, SkillId.Mon_boss_RingCrawler_Skill_6, SkillId.Mon_F_boss_Velniamonkey_Skill_1, SkillId.Mon_boss_Nuaelle_Skill_4, SkillId.Mon_F_boss_ellaganos_Skill_3, SkillId.Mon_boss_Lapedame_Skill_5, SkillId.Mon_F_boss_Velniamonkey_Skill_2, SkillId.Mon_boss_SwordBallista_Skill_1, SkillId.Mon_boss_SwordBallista_Skill_2, SkillId.Mon_boss_Armaox_Skill_6, SkillId.Mon_kucarry_numani_Skill_2, SkillId.Mon_kucarry_zabbi_Skill_2, SkillId.Mon_kucarry_balzer_Skill_2, SkillId.Mon_castle_gardner_Skill_2, SkillId.Mon_castle_gardner_Skill_3, SkillId.Mon_ragged_bird_Skill_1, SkillId.Mon_pumpkin_dog_Skill_2, SkillId.Mon_floron_Skill_1, SkillId.Mon_bloom_Skill_2, SkillId.Mon_roderiot_Skill_2, SkillId.Mon_rodevassal_Skill_3, SkillId.Mon_boss_Frogola_Q1_Skill_1, SkillId.Mon_boss_Frogola_Q1_Skill_4, SkillId.Mon_boss_torelodeer_Skill_2, SkillId.Mon_boss_torelodeer_Skill_5, SkillId.Mon_boss_gesti_Q1_Skill_3, SkillId.Mon_F_boss_Nuaelle_Skill_5, SkillId.Mon_ID_boss_Armaox_Skill_6, SkillId.Mon_F_boss_Blud_Skill_8, SkillId.Mon_F_boss_Nuaelle_Skill_7, SkillId.Mon_aklasbairn_Skill_2, SkillId.Mon_aklascenser_Skill_2, SkillId.Mon_aklashump_Skill_1, SkillId.Mon_aklashump_Skill_2, SkillId.Mon_boss_priest_of_dawn_Skill_2, SkillId.Mon_boss_aklasprincess_Skill_3, SkillId.Mon_boss_aklasprincess_Skill_4, SkillId.Mon_boss_aklasprincess_Skill_5, SkillId.Mon_Flamme_mage_Skill_3, SkillId.Mon_tala_sorcerer_Skill_3, SkillId.Mon_bloom_Skill_3, SkillId.Mon_kucarry_zeuni_Skill_3, SkillId.Mon_boss_Castle_princess_Skill_5, SkillId.Mon_boss_kucarry_balzermancer_Skill_2, SkillId.Mon_pc_summon_boss_Silva_griffin_Skill_2, SkillId.Mon_pc_summon_boss_castle_princess_Skill_3, SkillId.Mon_GRB_boss_Chapparition_Skill_2, SkillId.Mon_GRB_boss_Sequoia_white_Skill_1, SkillId.Mon_GRB_boss_Sequoia_white_Skill_2, SkillId.Mon_GFB_boss_Gosal_Skill_2, SkillId.Mon_GFB_boss_bebraspion_Skill_4, SkillId.Mon_boss_Velnipper_Skill_3, SkillId.Mon_boss_kabad_Skill_3, SkillId.Mon_boss_ignas_Skill_3, SkillId.Mon_boss_solcomm_Skill_5, SkillId.Mon_F_boss_Glackuman_Skill_6, SkillId.Mon_F_boss_Fireload_Skill_4, SkillId.Mon_ID_kucarry_zabbi_Skill_2, SkillId.Mon_boss_solcomm_Q2_Skill_5, SkillId.Mon_pc_summon_boss_SwordBallista_Skill_1, SkillId.Mon_pc_summon_boss_SwordBallista_Skill_2, SkillId.Mon_F_boss_solcomm_Skill_1, SkillId.Mon_F_boss_solcomm_Skill_2, SkillId.Mon_F_boss_solcomm_Skill_8, SkillId.Mon_uniq_id_boss_Spector_F_Skill_6, SkillId.Mon_NightPanto_mage_Skill_2, SkillId.Mon_d_uniq_boss_valdovas_Skill_7, SkillId.Mon_d_uniq_raid_boss_froster_lord_Skill_2, SkillId.Mon_d_uniq_raid_boss_froster_lord_Skill_4, SkillId.Mon_d_uniq_raid_boss_froster_lord_Skill_6, SkillId.Mon_boss_PervadingQueen_Skill_2, SkillId.Mon_Boss_TealSpecter_Skill_2, SkillId.Mon_boss_Wastrel_Red_Skill_2, SkillId.Mon_boss_Wastrel_Red_Skill_3, SkillId.Mon_WhimEclipse_Skill_1, SkillId.Mon_WhimEclipse_Skill_3, SkillId.Mon_weekly_boss_solcom_Skill_1, SkillId.Mon_weekly_boss_solcom_Skill_2, SkillId.Mon_weekly_boss_solcom_Skill_8, SkillId.Mon_weekly_boss_Nuaelle_Skill_2, SkillId.Mon_weekly_boss_Nuaelle_Skill_3, SkillId.Mon_weekly_boss_Nuaelle_Skill_5, SkillId.Mon_weekly_boss_Nuaelle_Skill_7, SkillId.Mon_weekly_boss_Nuaelle_Skill_8, SkillId.Mon_weekly_boss_Blud_Skill_7, SkillId.Mon_weekly_boss_Blud_Skill_8, SkillId.Mon_weekly_boss_froster_lord_Skill_2, SkillId.Mon_weekly_boss_froster_lord_Skill_4, SkillId.Mon_field_boss_Nuaelle_Skill_2, SkillId.Mon_field_boss_Nuaelle_Skill_3, SkillId.Mon_field_boss_Nuaelle_Skill_5, SkillId.Mon_field_boss_Nuaelle_Skill_7, SkillId.Mon_field_boss_Nuaelle_Skill_8, SkillId.Mon_field_boss_Blud_Skill_7, SkillId.Mon_field_boss_Blud_Skill_8, SkillId.Mon_field_boss_froster_lord_Skill_2, SkillId.Mon_field_boss_froster_lord_Skill_4, SkillId.Mon_FD_boss_froster_lord_Skill_3)]
	public class Mon_BW_boss_torelodeer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_torelodeer_Skill_3, SkillId.Mon_boss_Foculus_Skill_2, SkillId.Mon_boss_torelodeer_Skill_3, SkillId.Mon_aklascountess_Skill_2)]
	public class Mon_BW_boss_torelodeer_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_hauberk_Skill_1)]
	public class Mon_BW_boss_hauberk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_aklasprincess_Skill_3)]
	public class Mon_BW_boss_aklasprincess_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_banshee_Skill_1)]
	public class Mon_BW_boss_banshee_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Pinscher_Skill_1)]
	public class Mon_BW_boss_Pinscher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Velcoffer_Skill_3)]
	public class Mon_BW_boss_Velcoffer_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Monster_Slow, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_BW_boss_Velcoffer_Skill_5)]
	public class Mon_BW_boss_Velcoffer_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_BW_crystal_tower_Skill_1)]
	public class Mon_BW_crystal_tower_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Misrus_Skill_1, SkillId.Mon_Raid_boss_Misrus_Skill_1)]
	public class Mon_BW_boss_Misrus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Misrus_Skill_2, SkillId.Mon_Raid_boss_Misrus_Skill_2)]
	public class Mon_BW_boss_Misrus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(13999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(13799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Vasilissa_Skill_1, SkillId.Mon_boss_Vasilissa_Skill_1)]
	public class Mon_BW_boss_Vasilissa_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 55f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Vasilissa_Skill_2, SkillId.Mon_boss_Vasilissa_Skill_2)]
	public class Mon_BW_boss_Vasilissa_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10899);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10699);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Vasilissa_Skill_4)]
	public class Mon_BW_boss_Vasilissa_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 67f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Vasilissa_Skill_5, SkillId.Mon_boss_Vasilissa_Skill_11)]
	public class Mon_BW_boss_Vasilissa_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Vasilissa_Skill_8)]
	public class Mon_BW_boss_Vasilissa_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Vasilissa_Skill_10, SkillId.Mon_boss_Vasilissa_Skill_22)]
	public class Mon_BW_boss_Vasilissa_Skill_10 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.VASILISSA_AQUAPRISON_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_BW_boss_upinis_Skill_2, SkillId.Mon_weekly_boss_roze_Skill_2, SkillId.Mon_weekly_boss_upinis_Skill_2, SkillId.Mon_boss_Roze_Skill_2, SkillId.Mon_boss_Roze_Auto_Skill_2, SkillId.Mon_boss_Roze_Solo_Skill_2, SkillId.Mon_boss_upinis_Skill_2, SkillId.Mon_boss_upinis_Auto_Skill_2, SkillId.Mon_boss_upinis_Solo_Skill_2, SkillId.Mon_earring_upinis_Skill_2, SkillId.Mon_earring_slogutis_Skill_1)]
	public class Mon_BW_boss_upinis_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_upinis_Skill_3, SkillId.Mon_weekly_boss_upinis_Skill_3, SkillId.Mon_boss_upinis_Skill_3, SkillId.Mon_boss_upinis_Auto_Skill_3, SkillId.Mon_boss_upinis_Solo_Skill_3, SkillId.Mon_boss_upinis_Q1_Skill_3)]
	public class Mon_BW_boss_upinis_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_upinis_Skill_4, SkillId.Mon_weekly_boss_roze_Skill_5, SkillId.Mon_weekly_boss_upinis_Skill_5, SkillId.Mon_boss_Roze_Skill_5, SkillId.Mon_boss_Roze_Auto_Skill_5, SkillId.Mon_boss_Roze_Solo_Skill_5, SkillId.Mon_boss_upinis_Skill_5, SkillId.Mon_boss_upinis_Auto_Skill_5, SkillId.Mon_boss_upinis_Solo_Skill_5, SkillId.Mon_boss_upinis_Q1_Skill_5)]
	public class Mon_BW_boss_upinis_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_upinis_Skill_5, SkillId.Mon_weekly_boss_upinis_Skill_6, SkillId.Mon_boss_upinis_Skill_6, SkillId.Mon_boss_upinis_Auto_Skill_6, SkillId.Mon_boss_upinis_Solo_Skill_6, SkillId.Mon_earring_upinis_Skill_3)]
	public class Mon_BW_boss_upinis_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Slogutis_Skill_1, SkillId.Mon_BW_boss_Slogutis_Skill_8, SkillId.Mon_BW_boss_Slogutis_Skill_9, SkillId.Mon_weekly_boss_slogutis_Skill_1, SkillId.Mon_weekly_boss_slogutis_Skill_13, SkillId.Mon_weekly_boss_slogutis_Skill_15, SkillId.Mon_weekly_boss_slogutis_Skill_16, SkillId.Mon_weekly_boss_slogutis_Skill_17, SkillId.Mon_boss_Slogutis_Skill_1, SkillId.Mon_boss_Slogutis_Skill_4, SkillId.Mon_boss_Slogutis_Skill_15, SkillId.Mon_boss_Slogutis_Skill_17, SkillId.Mon_boss_Slogutis_Skill_18, SkillId.Mon_boss_Slogutis_Skill_20, SkillId.Mon_boss_Slogutis_Skill_21, SkillId.Mon_boss_Slogutis_Skill_22, SkillId.Mon_boss_Slogutis_Auto_Skill_1, SkillId.Mon_boss_Slogutis_Auto_Skill_4, SkillId.Mon_boss_Slogutis_Auto_Skill_15, SkillId.Mon_boss_Slogutis_Auto_Skill_17, SkillId.Mon_boss_Slogutis_Auto_Skill_18, SkillId.Mon_boss_Slogutis_Auto_Skill_20, SkillId.Mon_boss_Slogutis_Auto_Skill_21, SkillId.Mon_boss_Slogutis_Auto_Skill_22, SkillId.Mon_boss_Slogutis_Solo_Skill_1, SkillId.Mon_boss_Slogutis_Solo_Skill_4, SkillId.Mon_boss_Slogutis_Solo_Skill_15, SkillId.Mon_boss_Slogutis_Solo_Skill_17, SkillId.Mon_boss_Slogutis_Solo_Skill_18, SkillId.Mon_boss_Slogutis_Solo_Skill_20, SkillId.Mon_boss_Slogutis_Solo_Skill_21, SkillId.Mon_boss_Slogutis_Solo_Skill_22)]
	public class Mon_BW_boss_Slogutis_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Slogutis_Skill_2, SkillId.Mon_weekly_boss_slogutis_Skill_2, SkillId.Mon_pc_summon_boss_Slogutis_Skill_1, SkillId.Mon_boss_Slogutis_Skill_2, SkillId.Mon_boss_Slogutis_Auto_Skill_2, SkillId.Mon_boss_Slogutis_Solo_Skill_2)]
	public class Mon_BW_boss_Slogutis_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Slogutis_Skill_3, SkillId.Mon_weekly_boss_slogutis_Skill_5, SkillId.Mon_boss_Slogutis_Skill_6, SkillId.Mon_boss_Slogutis_Auto_Skill_6, SkillId.Mon_boss_Slogutis_Solo_Skill_6)]
	public class Mon_BW_boss_Slogutis_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Slogutis_Skill_4, SkillId.Mon_weekly_boss_slogutis_Skill_7, SkillId.Mon_boss_Slogutis_Skill_8, SkillId.Mon_boss_Slogutis_Auto_Skill_8, SkillId.Mon_boss_Slogutis_Solo_Skill_8)]
	public class Mon_BW_boss_Slogutis_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BW_boss_Slogutis_Skill_6, SkillId.Mon_weekly_boss_slogutis_Skill_10, SkillId.Mon_pc_summon_boss_Slogutis_Skill_3, SkillId.Mon_boss_Slogutis_Skill_12, SkillId.Mon_boss_Slogutis_Auto_Skill_12, SkillId.Mon_boss_Slogutis_Solo_Skill_12)]
	public class Mon_BW_boss_Slogutis_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_lecifer_Skill_2)]
	public class Mon_RE_boss_lecifer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_lecifer_Skill_7)]
	public class Mon_RE_boss_lecifer_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_solcomm_Skill_1)]
	public class Mon_RE_boss_solcomm_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_solcomm_Skill_3, SkillId.Mon_boss_solcomm_Skill_3, SkillId.Mon_boss_solcomm_Q2_Skill_3)]
	public class Mon_RE_boss_solcomm_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_solcomm_Skill_4)]
	public class Mon_RE_boss_solcomm_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_solcomm_Skill_7)]
	public class Mon_RE_boss_solcomm_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_zawra_Skill_1, SkillId.Mon_RE_boss_zawra_Skill_7)]
	public class Mon_RE_boss_zawra_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_zawra_Skill_6)]
	public class Mon_RE_boss_zawra_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_zawra_Skill_8)]
	public class Mon_RE_boss_zawra_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_helga_Skill_1)]
	public class Mon_RE_boss_helga_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_helga_Skill_2)]
	public class Mon_RE_boss_helga_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_helga_Skill_4)]
	public class Mon_RE_boss_helga_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 150f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_gresmetruth_Skill_1, SkillId.Mon_demonlair_bleakferret_cannon_Skill_2, SkillId.Mon_ep14_1_Bleakferret_Cannon_Skill_2, SkillId.Mon_boss_GresmeTruth_Skill_1)]
	public class Mon_RE_boss_gresmetruth_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_nuaelle_Skill_1, SkillId.Mon_weekly_boss_Nuaelle_Skill_1, SkillId.Mon_field_boss_Nuaelle_Skill_1)]
	public class Mon_RE_boss_nuaelle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9799);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_marnoks_Skill_1, SkillId.Mon_F_boss_Marnoks_Skill_1, SkillId.Mon_weekly_boss_Marnoks_Skill_1, SkillId.Mon_field_boss_Marnoks_Skill_1)]
	public class Mon_RE_boss_marnoks_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 80.006f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_chiefguard_Skill_5, SkillId.Mon_demonlair_mokslas_valdovas_Skill_2, SkillId.Mon_demonlair_mokslas_valdovas_Skill_3, SkillId.Mon_kisylion_Skill_2, SkillId.Mon_Uniq_Boss_Moringponia_Skill_8, SkillId.Mon_Legend_Boss_Moringponia_Skill_8, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_8, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_9, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_10, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_12, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_13, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_14, SkillId.Mon_Legend_Boss_Tantaliser_Skill_8, SkillId.Mon_Legend_Boss_Tantaliser_Skill_9, SkillId.Mon_Legend_Boss_Tantaliser_Skill_10, SkillId.Mon_Legend_Boss_Tantaliser_Skill_12, SkillId.Mon_Legend_Boss_Tantaliser_Skill_13, SkillId.Mon_Legend_Boss_Tantaliser_Skill_14, SkillId.Mon_weekly_pattern_Skill_1, SkillId.Mon_weekly_pattern_Skill_7, SkillId.Mon_weekly_pattern_Skill_9, SkillId.Mon_weekly_boss_mirtis_Skill_1, SkillId.Mon_weekly_pattern_Skill_21, SkillId.Mon_weekly_pattern_Skill_29, SkillId.Mon_weekly_pattern_Skill_32, SkillId.Mon_weekly_pattern_Skill_36, SkillId.Mon_weekly_pattern_Skill_47, SkillId.Mon_weekly_pattern_Skill_48, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_8, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_10, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_12, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_13, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_14, SkillId.Mon_weekly_boss_ChiefGuard_Skill_7, SkillId.Mon_weekly_boss_Tiny_bow_Skill_2, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_8, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_10, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_12, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_13, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_14, SkillId.Mon_field_pattern_Skill_1, SkillId.Mon_field_pattern_Skill_4, SkillId.Mon_field_pattern_Skill_12, SkillId.Mon_field_pattern_Skill_15, SkillId.Mon_field_pattern_Skill_16, SkillId.Mon_field_pattern_Skill_18, SkillId.Mon_field_pattern_Skill_24, SkillId.Mon_field_pattern_Skill_25, SkillId.Mon_field_boss_mirtis_Skill_1, SkillId.Mon_field_boss_ChiefGuard_Skill_7, SkillId.Mon_mythic_pattern_Skill_1, SkillId.Mon_mythic_pattern_Skill_8, SkillId.Mon_mythic_pattern_Skill_16, SkillId.Mon_mythic_pattern_Skill_17, SkillId.Mon_mythic_pattern_Skill_18, SkillId.Mon_mythic_pattern_Skill_19, SkillId.Mon_mythic_pattern_Skill_20, SkillId.Mon_mythic_pattern_Skill_26, SkillId.Mon_mythic_pattern_Skill_27, SkillId.Mon_mythic_pattern_Skill_29, SkillId.Mon_boss_mokslas_valdovas_Skill_2, SkillId.Mon_boss_mokslas_valdovas_Skill_3, SkillId.Mon_boss_mokslas_valdovas_Skill_5, SkillId.Mon_boss_blackman_Skill_1, SkillId.Mon_boss_blackman_Skill_2, SkillId.Mon_boss_blackman_Skill_5, SkillId.Mon_npc_baubas2_Skill_5)]
	public class Mon_RE_boss_chiefguard_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_froster_lord_Skill_2, SkillId.Mon_d_uniq_raid_boss_froster_lord_Skill_3, SkillId.Mon_weekly_boss_froster_lord_Skill_3, SkillId.Mon_field_boss_froster_lord_Skill_3, SkillId.Mon_FD_boss_froster_lord_Skill_2)]
	public class Mon_RE_boss_froster_lord_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_frostbite, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_RE_boss_naktis_Skill_2, SkillId.Mon_RE_boss_naktis_field_Skill_2, SkillId.Mon_weekly_boss_Naktis_Skill_2, SkillId.Mon_field_boss_Naktis_Skill_2)]
	public class Mon_RE_boss_naktis_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Hold, 1, 0, TimeSpan.FromMilliseconds(1000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_RE_boss_goblin_warrior_blue_Skill_1)]
	public class Mon_RE_boss_goblin_warrior_blue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_ellaganos_Skill_3, SkillId.Mon_bubbe_mage_fire_Skill_2, SkillId.Mon_boss_ellaganos_Skill_3, SkillId.Mon_boss_RytaSwort_Skill_4, SkillId.Mon_helgasercle_phantom_Skill_1, SkillId.Mon_ellogua_Skill_2, SkillId.Mon_boss_hydra_Skill_1, SkillId.Mon_arrow_trap_Skill_1, SkillId.Mon_GM_arrow_trap_Skill_2, SkillId.Mon_Legend_RytaSwort_Skill_1, SkillId.Mon_Legend_Hard_RytaSwort_Skill_1)]
	public class Mon_RE_boss_ellaganos_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_ellaganos_Skill_4, SkillId.Mon_boss_ellaganos_Skill_4, SkillId.Mon_pc_summon_ellaganos_Skill_2)]
	public class Mon_RE_boss_ellaganos_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_molich_Skill_2, SkillId.Mon_boss_molich_Skill_2)]
	public class Mon_RE_boss_molich_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_molich_Skill_3)]
	public class Mon_RE_boss_molich_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_spector_Skill_1)]
	public class Mon_RE_boss_spector_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_bearkaras_Skill_4, SkillId.Mon_boss_bearkaras_Skill_1)]
	public class Mon_RE_boss_bearkaras_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_fallen_statue_blue_Skill_2, SkillId.Mon_RE_boss_fallen_statue_blue_Skill_4, SkillId.Mon_boss_Fallen_Statue_Skill_2, SkillId.Mon_boss_chafer_Skill_4, SkillId.Mon_boss_mushcaria_Skill_5, SkillId.Mon_F_boss_Chafer_Skill_4, SkillId.Mon_F_boss_Chafer_Skill_5, SkillId.Mon_boss_Fallen_Statue_Skill_4, SkillId.Mon_boss_Chafer_Q1_Skill_4, SkillId.Mon_boss_Mushcaria_Q2_Skill_3, SkillId.Mon_pc_summon_boss_Fallen_Statue_Skill_2, SkillId.Mon_GFB_boss_chafer_Skill_4)]
	public class Mon_RE_boss_fallen_statue_blue_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0.1f;
		protected override float Width { get; } = 0.1f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_poata_Skill_1, SkillId.Mon_boss_poata_Skill_1, SkillId.Mon_M_boss_poata_Skill_1, SkillId.Mon_boss_poata_Q1_Skill_1)]
	public class Mon_RE_boss_poata_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_genmagnus_Skill_2, SkillId.Mon_boss_Genmagnus_Skill_2)]
	public class Mon_RE_boss_genmagnus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 100f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 30)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_RE_boss_bebraspion_Skill_3)]
	public class Mon_RE_boss_bebraspion_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_RE_boss_bebraspion_Skill_4, SkillId.Mon_boss_bebraspion_Skill_4)]
	public class Mon_RE_boss_bebraspion_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_shock, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_RE_boss_magburk_Skill_1, SkillId.Mon_boss_MagBurk_Skill_1)]
	public class Mon_RE_boss_magburk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_RE_boss_glass_mole_Skill_2, SkillId.Mon_boss_Glass_mole_Skill_2)]
	public class Mon_RE_boss_glass_mole_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Stun, 1, 0, TimeSpan.FromMilliseconds(2000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_RE_boss_varleking_Skill_1, SkillId.Mon_boss_varleking_Skill_1)]
	public class Mon_RE_boss_varleking_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 115f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 8)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_RE_boss_varleking_Skill_2, SkillId.Mon_boss_varleking_Skill_2)]
	public class Mon_RE_boss_varleking_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_event_boss_lucy_Skill_1, SkillId.Mon_event_boss_lucy_Skill_4, SkillId.Mon_event_boss_snigo_Skill_5, SkillId.Mon_earring_slogutis_Skill_2)]
	public class Mon_event_boss_lucy_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_event_boss_lucy_Skill_2)]
	public class Mon_event_boss_lucy_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_event_boss_lucy_Skill_6, SkillId.Mon_weekly_boss_lucy_Skill_6)]
	public class Mon_event_boss_lucy_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.StopAni, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_event_boss_snigo_Skill_1)]
	public class Mon_event_boss_snigo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_event_boss_snigo_Skill_2)]
	public class Mon_event_boss_snigo_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_event_boss_snigo_Skill_3)]
	public class Mon_event_boss_snigo_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_event_boss_pbeta_Skill_1)]
	public class Mon_event_boss_pbeta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_event_boss_skiaclipse_sealed_nocage_Skill_2, SkillId.Mon_Raid_boss_Skiaclipse_Sealed_Nocage_Skill_2, SkillId.Mon_Raid_boss_Skiaclipse_Sealed_Nocage_Solo_Skill_2)]
	public class Mon_event_boss_skiaclipse_sealed_nocage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10119);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9919);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_roze_Skill_6, SkillId.Mon_boss_Roze_Skill_6, SkillId.Mon_boss_Roze_Auto_Skill_6, SkillId.Mon_boss_Roze_Solo_Skill_6)]
	public class Mon_weekly_boss_roze_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_roze_Skill_7, SkillId.Mon_boss_Roze_Skill_8, SkillId.Mon_boss_Roze_Auto_Skill_8, SkillId.Mon_boss_Roze_Solo_Skill_8, SkillId.Mon_boss_upinis_Skill_8, SkillId.Mon_boss_upinis_Auto_Skill_8, SkillId.Mon_boss_upinis_Solo_Skill_8)]
	public class Mon_weekly_boss_roze_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_upinis_Skill_7, SkillId.Mon_weekly_boss_upinis_Skill_14, SkillId.Mon_boss_upinis_Skill_7, SkillId.Mon_boss_upinis_Skill_20, SkillId.Mon_boss_upinis_Auto_Skill_7, SkillId.Mon_boss_upinis_Auto_Skill_20, SkillId.Mon_boss_upinis_Solo_Skill_7, SkillId.Mon_boss_upinis_Solo_Skill_20)]
	public class Mon_weekly_boss_upinis_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_slogutis_Skill_3, SkillId.Mon_boss_Slogutis_Skill_3, SkillId.Mon_boss_Slogutis_Auto_Skill_3, SkillId.Mon_boss_Slogutis_Solo_Skill_3)]
	public class Mon_weekly_boss_slogutis_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_slogutis_Skill_8, SkillId.Mon_pc_summon_boss_Slogutis_Skill_2, SkillId.Mon_boss_Slogutis_Skill_9, SkillId.Mon_boss_Slogutis_Auto_Skill_9, SkillId.Mon_boss_Slogutis_Solo_Skill_9)]
	public class Mon_weekly_boss_slogutis_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_slogutis_Skill_14, SkillId.Mon_boss_Slogutis_Skill_16, SkillId.Mon_boss_Slogutis_Auto_Skill_16, SkillId.Mon_boss_Slogutis_Solo_Skill_16)]
	public class Mon_weekly_boss_slogutis_Skill_14 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_spreader_Skill_1, SkillId.Mon_boss_TransmutationSpreader_Skill_1)]
	public class Mon_weekly_boss_spreader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 55f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_spreader_Skill_3, SkillId.Mon_boss_TransmutationSpreader_Skill_3, SkillId.Mon_boss_TransmutationSpreader_Skill_13, SkillId.Mon_earring_spreader_Skill_1, SkillId.Mon_earring_spreader_Skill_5)]
	public class Mon_weekly_boss_spreader_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_falouros_Skill_2, SkillId.Mon_earring_falouros_Skill_2)]
	public class Mon_weekly_boss_falouros_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_falouros_Skill_3, SkillId.Mon_weekly_boss_falouros_Skill_6, SkillId.Mon_boss_Falouros_Skill_3, SkillId.Mon_boss_Falouros_Auto_Skill_3, SkillId.Mon_boss_Falouros_Solo_Skill_3, SkillId.Mon_earring_falouros_Skill_5)]
	public class Mon_weekly_boss_falouros_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_falouros_Skill_4, SkillId.Mon_earring_falouros_Skill_3)]
	public class Mon_weekly_boss_falouros_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_falouros_Skill_7, SkillId.Mon_boss_Falouros_Skill_10, SkillId.Mon_boss_Falouros_Auto_Skill_10, SkillId.Mon_boss_Falouros_Solo_Skill_10)]
	public class Mon_weekly_boss_falouros_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_leader_canceril_Skill_1, SkillId.Mon_boss_Canceril_Skill_1)]
	public class Mon_ep16_1_leader_canceril_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ep16_1_leader_velniamonkey_Skill_1, SkillId.Mon_boss_Velniamonkey_Skill_1)]
	public class Mon_ep16_1_leader_velniamonkey_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_leader_durahan_Skill_1, SkillId.Mon_boss_durahan_Skill_1)]
	public class Mon_ep16_1_leader_durahan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_leader_unicorn_Skill_2, SkillId.Mon_boss_unicorn_Skill_2)]
	public class Mon_ep16_1_leader_unicorn_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_leader_onion_the_great_Skill_3, SkillId.Mon_boss_onion_the_great_Skill_3, SkillId.Mon_GRB_boss_onion_the_great_Skill_3)]
	public class Mon_leader_onion_the_great_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_archon_Skill_1, SkillId.Mon_boss_archon_Skill_1)]
	public class Mon_leader_archon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_leader_centaurus_Skill_5)]
	public class Mon_leader_centaurus_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_silva_griffin_Skill_1)]
	public class Mon_leader_silva_griffin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_leader_silva_griffin_Skill_2)]
	public class Mon_leader_silva_griffin_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_mandara_Skill_1)]
	public class Mon_leader_mandara_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_rocksodon_Skill_4, SkillId.Mon_boss_Rocksodon_Skill_4)]
	public class Mon_leader_rocksodon_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_stalakan_Skill_3, SkillId.Mon_ep12_Neckko_Skill_1)]
	public class Mon_leader_stalakan_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_leader_kandlogre_Skill_1)]
	public class Mon_leader_kandlogre_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_leader_woodcenturion_Skill_1, SkillId.Mon_boss_WoodCenturion_Skill_1)]
	public class Mon_leader_woodcenturion_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_trampler_Skill_1, SkillId.Mon_boss_Trampler_Skill_1)]
	public class Mon_leader_trampler_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_leader_trampler_Skill_5, SkillId.Mon_boss_Trampler_Skill_5)]
	public class Mon_leader_trampler_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 200f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_leader_darbas_smasher_Skill_1, SkillId.Mon_boss_darbas_smasher_Skill_1)]
	public class Mon_leader_darbas_smasher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_leader_blackdevilglove_Skill_1, SkillId.Mon_boss_blackdevilglove_Skill_1)]
	public class Mon_leader_blackdevilglove_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_blackdevilglove_Skill_2, SkillId.Mon_GM_boss_BlackDevilglove_Skill_2, SkillId.Mon_boss_blackdevilglove_Skill_2)]
	public class Mon_leader_blackdevilglove_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_blackdevilglove_Skill_4, SkillId.Mon_boss_blackdevilglove_Skill_4)]
	public class Mon_leader_blackdevilglove_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_liepsna_firebug_Skill_1, SkillId.Mon_boss_liepsna_firebug_Skill_1)]
	public class Mon_leader_liepsna_firebug_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_saugumas_executor_Skill_1, SkillId.Mon_boss_saugumas_executor_Skill_1)]
	public class Mon_leader_saugumas_executor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_leader_saugumas_executor_Skill_3, SkillId.Mon_boss_saugumas_executor_Skill_3)]
	public class Mon_leader_saugumas_executor_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(5000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(4800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_upinis_Skill_1)]
	public class Mon_pc_summon_boss_upinis_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.FREEZE_EFFECT, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_pc_summon_Legend_card_Redania_Skill_1, SkillId.Mon_boss_Redania_Skill_2, SkillId.Mon_boss_Redania_Skill_4, SkillId.Mon_boss_Redania_Skill_6, SkillId.Mon_boss_Redania_Skill_7, SkillId.Mon_boss_Redania_Skill_8, SkillId.Mon_boss_Redania_Skill_9, SkillId.Mon_boss_Redania_Skill_10, SkillId.Mon_boss_Redania_Skill_11, SkillId.Mon_boss_Redania_Auto_Skill_2, SkillId.Mon_boss_Redania_Auto_Skill_4, SkillId.Mon_boss_Redania_Auto_Skill_6, SkillId.Mon_boss_Redania_Auto_Skill_7, SkillId.Mon_boss_Redania_Auto_Skill_8, SkillId.Mon_boss_Redania_Auto_Skill_9, SkillId.Mon_boss_Redania_Auto_Skill_10, SkillId.Mon_boss_Redania_Auto_Skill_11, SkillId.Mon_boss_Redania_Solo_Skill_2, SkillId.Mon_boss_Redania_Solo_Skill_4, SkillId.Mon_boss_Redania_Solo_Skill_6, SkillId.Mon_boss_Redania_Solo_Skill_7, SkillId.Mon_boss_Redania_Solo_Skill_8, SkillId.Mon_boss_Redania_Solo_Skill_9, SkillId.Mon_boss_Redania_Solo_Skill_10, SkillId.Mon_boss_Redania_Solo_Skill_11, SkillId.Mon_boss_Redania_Illusion_Skill_2, SkillId.Mon_boss_Redania_Illusion_Skill_4, SkillId.Mon_boss_Redania_Illusion_Skill_6, SkillId.Mon_boss_Redania_Illusion_Skill_7, SkillId.Mon_boss_Redania_Illusion_Skill_8, SkillId.Mon_boss_Redania_Illusion_Skill_9, SkillId.Mon_boss_Redania_Illusion_Skill_10, SkillId.Mon_boss_Redania_Illusion_Skill_11)]
	public class Mon_pc_summon_Legend_card_Redania_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10499);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10299);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_dumaro_blue_Skill_1)]
	public class Mon_demonlair_dumaro_blue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_demonlair_dumaro_blue_Skill_2, SkillId.Mon_demonlair_dumaro_dump_Skill_2, SkillId.Mon_ep13_2_Dumaro_Skill_2)]
	public class Mon_demonlair_dumaro_blue_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_wendigo_blue_Skill_1, SkillId.Mon_demonlair_wendigo_dump_Skill_1)]
	public class Mon_demonlair_wendigo_blue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_demonlair_wendigo_blue_Skill_2)]
	public class Mon_demonlair_wendigo_blue_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_sec_yekubite_Skill_1)]
	public class Mon_demonlair_sec_yekubite_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(780);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(580);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_demonlair_goblin_miners_blue_Skill_1)]
	public class Mon_demonlair_goblin_miners_blue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(920);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(720);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_demonlair_goblin_miners_blue_Skill_2, SkillId.Mon_Goblin_Spear_Attack2)]
	public class Mon_demonlair_goblin_miners_blue_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_demonlair_mokslas_valdovas_Skill_1, SkillId.Mon_boss_mokslas_valdovas_Skill_1)]
	public class Mon_demonlair_mokslas_valdovas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_demonlair_mokslas_researcher_Skill_1)]
	public class Mon_demonlair_mokslas_researcher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_demonlair_mokslas_researcher_Skill_2, SkillId.Mon_mokslas_researcher_Skill_2)]
	public class Mon_demonlair_mokslas_researcher_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_mokslas_fumigation_Skill_1)]
	public class Mon_demonlair_mokslas_fumigation_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 22f;
	}

	[SkillHandler(SkillId.Mon_demonlair_mokslas_doctor_Skill_1)]
	public class Mon_demonlair_mokslas_doctor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_demonlair_madness_wendigo_Skill_1, SkillId.Mon_ep13_2_wendigo_Skill_1)]
	public class Mon_demonlair_madness_wendigo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_madness_wendigo_Skill_2)]
	public class Mon_demonlair_madness_wendigo_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_wendigo_dump_Skill_2, SkillId.Mon_ep13_2_wendigo_dump_Skill_2)]
	public class Mon_demonlair_wendigo_dump_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_dumaro_dump_Skill_1, SkillId.Mon_boss_FD_succubus_Skill_1, SkillId.Mon_ep13_2_Dumaro_Skill_1)]
	public class Mon_demonlair_dumaro_dump_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_demonlair_goblin_brandingiron_Skill_1)]
	public class Mon_demonlair_goblin_brandingiron_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_goblin_brandingiron_Skill_2)]
	public class Mon_demonlair_goblin_brandingiron_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_banshee_Skill_1)]
	public class Mon_demonlair_banshee_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_demonlair_banshee_Skill_2)]
	public class Mon_demonlair_banshee_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_goblin_sweeper_Skill_1, SkillId.Mon_ep13_2_Goblin_sweeper_Skill_1)]
	public class Mon_demonlair_goblin_sweeper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 110f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_spear_Skill_1)]
	public class Mon_demonlair_bleakferret_spear_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_spear_Skill_2)]
	public class Mon_demonlair_bleakferret_spear_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_charger_Skill_1)]
	public class Mon_demonlair_bleakferret_charger_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_gladiator_Skill_1, SkillId.Mon_GM_bower_oblivion_Skill_1, SkillId.Mon_ep12_bower_oblivion_Skill_1)]
	public class Mon_demonlair_bleakferret_gladiator_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_gladiator_Skill_2)]
	public class Mon_demonlair_bleakferret_gladiator_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_shielder_Skill_1)]
	public class Mon_demonlair_bleakferret_shielder_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_shielder_Skill_2, SkillId.Mon_ep14_1_Bleakferret_shielder_Skill_2)]
	public class Mon_demonlair_bleakferret_shielder_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_gresmebird_Skill_1)]
	public class Mon_demonlair_gresmebird_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_demonlair_gresmebird_Skill_2, SkillId.Mon_ep14_1_GresmeBird_Skill_2)]
	public class Mon_demonlair_gresmebird_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_gresmecrow_Skill_1, SkillId.Mon_ep14_1_GresmeCrow_Skill_1)]
	public class Mon_demonlair_gresmecrow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_demonlair_transmutation_people_Skill_1, SkillId.Mon_ep14_1_TransmutationPeople_Skill_1)]
	public class Mon_demonlair_transmutation_people_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_demonlair_transmutation_people_Skill_2, SkillId.Mon_ep14_1_TransmutationPeople_Skill_2)]
	public class Mon_demonlair_transmutation_people_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_transmutation_merchant_Skill_1, SkillId.Mon_ep14_1_TransmutationMerchant_Skill_1)]
	public class Mon_demonlair_transmutation_merchant_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_demonlair_transmutation_soldier_Skill_1, SkillId.Mon_ep14_1_TransmutationSoldier_Skill_1)]
	public class Mon_demonlair_transmutation_soldier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_lancer_Skill_1)]
	public class Mon_demonlair_bleakferret_lancer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_lancer_Skill_2, SkillId.Mon_ep14_2_Bleakferret_Lancer_Skill_2)]
	public class Mon_demonlair_bleakferret_lancer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_demonlair_bleakferret_strange_Skill_1, SkillId.Mon_ep14_2_Bleakferret_Strange_Skill_1)]
	public class Mon_demonlair_bleakferret_strange_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 75f;
	}

	[SkillHandler(SkillId.Mon_boss_Giltine_Renewal_Skill_1, SkillId.Mon_Legend_Boss_Giltine_Skill_1, SkillId.Mon_Legend_Boss_Giltine_Guild_Skill_1, SkillId.Mon_Legend_Boss_Giltine_Auto_Skill_1)]
	public class Mon_boss_Giltine_Renewal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_boss_Giltine_Renewal_Skill_2, SkillId.Mon_boss_Giltine_Renewal_Skill_9, SkillId.Mon_boss_Giltine_Renewal_Skill_10, SkillId.Mon_Legend_Boss_Giltine_Skill_2, SkillId.Mon_Legend_Boss_Giltine_Skill_9, SkillId.Mon_Legend_Boss_Giltine_Skill_10, SkillId.Mon_Legend_Boss_Giltine_Guild_Skill_2, SkillId.Mon_Legend_Boss_Giltine_Guild_Skill_9, SkillId.Mon_Legend_Boss_Giltine_Guild_Skill_10, SkillId.Mon_Legend_Boss_Giltine_Auto_Skill_2, SkillId.Mon_Legend_Boss_Giltine_Auto_Skill_9, SkillId.Mon_Legend_Boss_Giltine_Auto_Skill_10)]
	public class Mon_boss_Giltine_Renewal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Giltine_Renewal_Skill_5, SkillId.Mon_Legend_Boss_Giltine_Skill_5, SkillId.Mon_Legend_Boss_Giltine_Guild_Skill_5, SkillId.Mon_Legend_Boss_Giltine_Auto_Skill_5)]
	public class Mon_boss_Giltine_Renewal_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Giltine_Renewal_Skill_8, SkillId.Mon_Legend_Boss_Giltine_Skill_8, SkillId.Mon_Legend_Boss_Giltine_Guild_Skill_8, SkillId.Mon_Legend_Boss_Giltine_Auto_Skill_8)]
	public class Mon_boss_Giltine_Renewal_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Giltine_Renewal_Skill_12, SkillId.Mon_Legend_Boss_Giltine_Skill_12, SkillId.Mon_Legend_Boss_Giltine_Guild_Skill_12, SkillId.Mon_Legend_Boss_Giltine_Auto_Skill_12)]
	public class Mon_boss_Giltine_Renewal_Skill_12 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Avataras_Renewal_Skill_2, SkillId.Mon_boss_Avataras_Renewal_Skill_6, SkillId.Mon_boss_Avataras_Renewal_Skill_8, SkillId.Mon_Legend_Boss_Avataras_Skill_2, SkillId.Mon_Legend_Boss_Avataras_Skill_6, SkillId.Mon_Legend_Boss_Avataras_Skill_8, SkillId.Mon_Legend_Boss_Avataras_Guild_Skill_2, SkillId.Mon_Legend_Boss_Avataras_Guild_Skill_6, SkillId.Mon_Legend_Boss_Avataras_Guild_Skill_8, SkillId.Mon_Legend_Boss_Avataras_Auto_Skill_2, SkillId.Mon_Legend_Boss_Avataras_Auto_Skill_6, SkillId.Mon_Legend_Boss_Avataras_Auto_Skill_8)]
	public class Mon_boss_Avataras_Renewal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Avataras_Renewal_Skill_14, SkillId.Mon_Legend_Boss_Avataras_Skill_14, SkillId.Mon_Legend_Boss_Avataras_Guild_Skill_14, SkillId.Mon_Legend_Boss_Avataras_Auto_Skill_14)]
	public class Mon_boss_Avataras_Renewal_Skill_14 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.GILTINE_ELECTRIC_SHOCK_STIFFNESS_DEBUFF, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_GM_bower_interfere_Skill_1, SkillId.Mon_ep12_bower_interfere_Skill_1)]
	public class Mon_GM_bower_interfere_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_GM_bower_obstructer_Skill_1, SkillId.Mon_ep12_bower_obstructer_Skill_1)]
	public class Mon_GM_bower_obstructer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_bower_Gather_Skill_1, SkillId.Mon_chesha_riel_Skill_2, SkillId.Mon_Uniq_Boss_Tantaliser_Skill_11, SkillId.Mon_weekly_pattern_Skill_2, SkillId.Mon_weekly_pattern_Skill_10, SkillId.Mon_weekly_pattern_Skill_17, SkillId.Mon_weekly_pattern_Skill_18, SkillId.Mon_weekly_pattern_Skill_20, SkillId.Mon_weekly_pattern_Skill_28, SkillId.Mon_weekly_pattern_Skill_35, SkillId.Mon_weekly_pattern_Skill_37, SkillId.Mon_weekly_pattern_Skill_38, SkillId.Mon_weekly_pattern_Skill_44, SkillId.Mon_weekly_pattern_Skill_45, SkillId.Mon_weekly_pattern_Skill_46, SkillId.Mon_weekly_pattern_Skill_49, SkillId.Mon_weekly_pattern_Skill_50, SkillId.Mon_weekly_boss_Zawra_Skill_11, SkillId.Mon_FieldRift_pattern_Skill_3, SkillId.Mon_Legend_moringaga_Hard_Skill_1, SkillId.Mon_weekly_boss_ChiefGuard_Skill_6, SkillId.Mon_weekly_boss_Tiny_mage_Skill_2, SkillId.Mon_Legend_Solo_moringaga_Skill_1, SkillId.Mon_Legend_Solo_moringaga_Skill_2, SkillId.Mon_Legend_Solo_moringaga_Skill_3, SkillId.Mon_Legend_Solo_moringaga_Skill_4, SkillId.Mon_Legend_Solo_moringaga_Skill_5, SkillId.Mon_field_pattern_Skill_6, SkillId.Mon_field_pattern_Skill_11, SkillId.Mon_field_pattern_Skill_14, SkillId.Mon_field_pattern_Skill_17, SkillId.Mon_field_pattern_Skill_19, SkillId.Mon_field_pattern_Skill_20, SkillId.Mon_field_pattern_Skill_21, SkillId.Mon_field_pattern_Skill_22, SkillId.Mon_field_pattern_Skill_23, SkillId.Mon_field_pattern_Skill_26, SkillId.Mon_field_pattern_Skill_27, SkillId.Mon_field_boss_Zawra_Skill_11, SkillId.Mon_field_boss_ChiefGuard_Skill_6, SkillId.Mon_mythic_pattern_Skill_7, SkillId.Mon_mythic_pattern_Skill_9, SkillId.Mon_mythic_pattern_Skill_10, SkillId.Mon_mythic_pattern_Skill_11, SkillId.Mon_mythic_pattern_Skill_12, SkillId.Mon_mythic_pattern_Skill_13, SkillId.Mon_mythic_pattern_Skill_14, SkillId.Mon_mythic_pattern_Skill_15, SkillId.Mon_mythic_pattern_Skill_21, SkillId.Mon_mythic_pattern_Skill_22, SkillId.Mon_mythic_pattern_Skill_23, SkillId.Mon_mythic_pattern_Skill_24, SkillId.Mon_mythic_pattern_Skill_25, SkillId.Mon_mythic_pattern_Skill_40, SkillId.Mon_TH_raganosis_cannon_Skill_2, SkillId.Mon_TH_bower_Gather_Skill_1, SkillId.Mon_TH_bower_Gather_Skill_2, SkillId.Mon_TH_orsha_catapult_Skill_1, SkillId.Mon_TH_orsha_catapult_Skill_2, SkillId.Mon_boss_blackman_Skill_6, SkillId.Mon_Vibora_Spiritwizard_Skill_3)]
	public class Mon_GM_bower_Gather_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_saugumas_guardion_Skill_1, SkillId.Mon_ep13_saugumas_guardion_Skill_1)]
	public class Mon_GM_saugumas_guardion_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_saugumas_sentinel_Skill_1, SkillId.Mon_ep13_saugumas_sentinel_Skill_1)]
	public class Mon_GM_saugumas_sentinel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_saugumas_defender_Skill_1, SkillId.Mon_ep13_saugumas_defender_Skill_1)]
	public class Mon_GM_saugumas_defender_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_saugumas_defender_Skill_2, SkillId.Mon_ep13_saugumas_defender_Skill_2)]
	public class Mon_GM_saugumas_defender_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_BowerKeeper_Destroyer_Skill_4, SkillId.Mon_GM_boss_BowerKeeper_Skill_4, SkillId.Mon_boss_BowerKeeper_Skill_4)]
	public class Mon_GM_BowerKeeper_Destroyer_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_Black_FireDragon_Skill_1, SkillId.Mon_Fire_Dragon_green_Skill_1, SkillId.Mon_Fire_Dragon_purple_Skill_1)]
	public class Mon_GM_Black_FireDragon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_Black_FireDragon_Skill_2, SkillId.Mon_Fire_Dragon_green_Skill_2, SkillId.Mon_Fire_Dragon_purple_Skill_2)]
	public class Mon_GM_Black_FireDragon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_GM_Black_Shardstatue_Skill_1, SkillId.Mon_Shardstatue_Skill_1)]
	public class Mon_GM_Black_Shardstatue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_GM_Malstatue_Skill_1, SkillId.Mon_Malstatue_Skill_1)]
	public class Mon_GM_Malstatue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_Black_Templeslave_Skill_1, SkillId.Mon_Templeslave_Skill_1)]
	public class Mon_GM_Black_Templeslave_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_GM_Black_Templeslave_Sword_Skill_1, SkillId.Mon_Templeslave_sword_Skill_1)]
	public class Mon_GM_Black_Templeslave_Sword_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Black_Templeslave_Sword_Skill_2, SkillId.Mon_Templeslave_sword_Skill_2)]
	public class Mon_GM_Black_Templeslave_Sword_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Viskal_Skill_1, SkillId.Mon_ep12_viskal_Skill_1)]
	public class Mon_GM_Viskal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Viskal_Skill_2, SkillId.Mon_GM_Poana_Skill_2, SkillId.Mon_ep12_viskal_Skill_2, SkillId.Mon_ep12_Orc_glaive_Skill_2, SkillId.Mon_ep12_Gari_Skill_2, SkillId.Mon_ep12_Poana_Skill_2)]
	public class Mon_GM_Viskal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_GM_Tarnaite_Skill_1, SkillId.Mon_ep12_Tarnaite_Skill_1)]
	public class Mon_GM_Tarnaite_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Tarnaite_Skill_2, SkillId.Mon_ep12_Tarnaite_Skill_2)]
	public class Mon_GM_Tarnaite_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Poana_Skill_1, SkillId.Mon_ep12_Poana_Skill_1)]
	public class Mon_GM_Poana_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Pawnta_Skill_1, SkillId.Mon_slime_witch_Skill_1, SkillId.Mon_ep12_Pawnta_Skill_1)]
	public class Mon_GM_Pawnta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Pawnta_Skill_2, SkillId.Mon_ep12_Pawnta_Skill_2)]
	public class Mon_GM_Pawnta_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Papillon_Solider_Skill_1, SkillId.Mon_ep15_2_Papillon_Solider_Skill_1)]
	public class Mon_GM_Papillon_Solider_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_Papillon_Solider_Skill_2, SkillId.Mon_ep15_2_Papillon_Solider_Skill_2)]
	public class Mon_GM_Papillon_Solider_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_Papillon_Assassin_Skill_1)]
	public class Mon_GM_Papillon_Assassin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 5f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_Papillon_leader_Skill_1)]
	public class Mon_GM_Papillon_leader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GM_Papillon_leader_Skill_2, SkillId.Mon_ep15_2_Papillon_leader_Skill_2)]
	public class Mon_GM_Papillon_leader_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 5f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_boss_BlackDevilglove_Skill_1)]
	public class Mon_GM_boss_BlackDevilglove_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_boss_BlackDevilglove_Skill_4)]
	public class Mon_GM_boss_BlackDevilglove_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_boss_Deathweaver_Skill_2)]
	public class Mon_GM_boss_Deathweaver_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 220f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_curse, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_GM_boss_Deathweaver_Skill_3, SkillId.Mon_F_boss_Deathweaver_Skill_3)]
	public class Mon_GM_boss_Deathweaver_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_curse, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_GM_boss_Deathweaver_Skill_6)]
	public class Mon_GM_boss_Deathweaver_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 7f;
	}

	[SkillHandler(SkillId.Mon_Onion_Big_Attack1, SkillId.Mon_ep13_2_banshee_Skill_1)]
	public class Mon_Onion_Big_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_rafflesia_Skill, SkillId.Mon_rafflesia_purple_Skill_1)]
	public class Mon_rafflesia_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_raffly_Attack1, SkillId.Mon_llapindal_ribbon_Skill_2, SkillId.Mon_ep16_2_llapindal_ribbon_Skill_2)]
	public class Mon_raffly_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_puragi_Attack1, SkillId.Mon_thornball_Attack1, SkillId.Mon_rambear_Skill_1, SkillId.Mon_rambear_Skill_2, SkillId.Mon_wood_goblin_red_Skill_1, SkillId.Mon_Worg_Skill_1, SkillId.Mon_saltisdaughter_Skill_1, SkillId.Mon_Minos_Skill_1, SkillId.Mon_Chromadog_Skill_2, SkillId.Mon_zigri_brown_Skill_1, SkillId.Mon_zinutekas_Skill_1, SkillId.Mon_woodfung_Skill_1, SkillId.Mon_Kepo_Skill_1, SkillId.Mon_Socket_Skill_2, SkillId.Mon_Colifly_black_Skill_1, SkillId.Mon_lantern_mushroom_orange_Skill_1, SkillId.Mon_ferret_vendor_Skill_1, SkillId.Mon_PagAmpullar_Skill_1, SkillId.Mon_rubblem_Skill_1, SkillId.Mon_nacorngfly_Skill_2)]
	public class Mon_puragi_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_puragi_Attack2, SkillId.Mon_bushspider_Attack2, SkillId.Mon_Pokubu_Attack, SkillId.Mon_Ridimed_Attack1, SkillId.Mon_bushspider_Skill_1, SkillId.Mon_Pokubu_Skill_1, SkillId.Mon_Pokubu_Gray_Skill_1, SkillId.Mon_puragi_green_Skill_2, SkillId.Mon_puragi_blue_Skill_1, SkillId.Mon_puragi_blue_Skill_3)]
	public class Mon_puragi_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_puragi_Skill)]
	public class Mon_puragi_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_zigri_Attack1, SkillId.Mon_zigri_purple_Skill_1, SkillId.Mon_rockon_Skill_1)]
	public class Mon_zigri_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_zigri_Skill, SkillId.Mon_zigri_brown_Skill_3)]
	public class Mon_zigri_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Fisherman_Attack1, SkillId.Mon_Hallowventor_Skill_1)]
	public class Mon_Fisherman_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Fisherman_Skill, SkillId.Mon_Fisherman_red_Skill_2)]
	public class Mon_Fisherman_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_arburn_pokubu_Attack1, SkillId.Mon_Beetle_Attack1, SkillId.Mon_gear_Skill_1, SkillId.Mon_wisnol_Skill_1, SkillId.Mon_ep16_2_gear_Skill_1, SkillId.Mon_event_Beetle_Attack1)]
	public class Mon_arburn_pokubu_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_bushspider_Attack1, SkillId.Mon_bushspider_Skill_2, SkillId.Mon_Bagworm_Attack)]
	public class Mon_bushspider_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_flower_blue_Attack1, SkillId.Mon_Paggnat_Skill_2)]
	public class Mon_flower_blue_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_flower_blue_Attack2)]
	public class Mon_flower_blue_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_flower_blue_Skill)]
	public class Mon_flower_blue_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_lantern_mushroom_Attack1)]
	public class Mon_lantern_mushroom_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_lantern_mushroom_Attack2, SkillId.Mon_bush_beetle_Skill_1)]
	public class Mon_lantern_mushroom_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_lantern_mushroom_Skill)]
	public class Mon_lantern_mushroom_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_banshee_Attack1, SkillId.Mon_Honeybean_Skill_1)]
	public class Mon_banshee_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_banshee_Attack2, SkillId.Mon_ID_Banshee_pink_Skill_2)]
	public class Mon_banshee_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_honey_bee_Attack1, SkillId.Mon_honey_bee_Attack2)]
	public class Mon_honey_bee_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mushroom_boy_Skill)]
	public class Mon_mushroom_boy_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_truffle_Attack1, SkillId.Mon_truffle_Attack2, SkillId.Mon_Tombstone_golem_Skill_2, SkillId.Mon_mythic_Truffle_Skill_1, SkillId.Mon_mythic_Truffle_Skill_2)]
	public class Mon_truffle_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_truffle_Skill, SkillId.Mon_mythic_Truffle_Skill_3)]
	public class Mon_truffle_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Haming_Attack2)]
	public class Mon_Haming_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Onion_Attack1, SkillId.Mon_Onion_red_Skill_1, SkillId.Mon_event_onion_Halloween_Skill_1)]
	public class Mon_Onion_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_slime_dark_Attack1)]
	public class Mon_slime_dark_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_slime_dark_Skill)]
	public class Mon_slime_dark_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1150);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_dionia_Skill_1)]
	public class Mon_boss_dionia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 130f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_pappus_kepa_Attack1)]
	public class Mon_pappus_kepa_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 5f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_matsum_Attack1)]
	public class Mon_matsum_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Sakmoli_Attack1)]
	public class Mon_Sakmoli_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Jukopus_Attack1, SkillId.Mon_Jukopus_gray_Skill_1)]
	public class Mon_Jukopus_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(970);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(770);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Jukopus_Attack2)]
	public class Mon_Jukopus_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mushroom_boy_color_Attack1)]
	public class Mon_mushroom_boy_color_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mushroom_boy_color_Skill)]
	public class Mon_mushroom_boy_color_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mushroom_ent_color_Attack1, SkillId.Mon_mushroom_ent_black_Skill_1)]
	public class Mon_mushroom_ent_color_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_treemonster_Attack1)]
	public class Mon_treemonster_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1250);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_treemonster_Attack2)]
	public class Mon_treemonster_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_treemonster_Skill)]
	public class Mon_treemonster_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Scorpion_Attack1)]
	public class Mon_Scorpion_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Scorpion_Attack2)]
	public class Mon_Scorpion_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tontulia_Attack1)]
	public class Mon_Tontulia_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tontulia_Attack2)]
	public class Mon_Tontulia_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tontus_Attack1)]
	public class Mon_Tontus_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_Tontus_Attack2)]
	public class Mon_Tontus_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Tontus_Skill)]
	public class Mon_Tontus_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Beetle_Attack2, SkillId.Mon_event_Beetle_Attack2)]
	public class Mon_Beetle_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Beetle_Skill, SkillId.Mon_event_Beetle_Skill)]
	public class Mon_Beetle_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Geppetto_Attack2)]
	public class Mon_Geppetto_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Geppetto_Skill)]
	public class Mon_Geppetto_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Moving_trap_Attack1)]
	public class Mon_Moving_trap_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 573f;
	}

	[SkillHandler(SkillId.Mon_Moving_trap_Attack2)]
	public class Mon_Moving_trap_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Moving_trap_Skill)]
	public class Mon_Moving_trap_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_New_desmodus_Skill)]
	public class Mon_New_desmodus_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Pino_Attack1)]
	public class Mon_Pino_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Pino_Attack2)]
	public class Mon_Pino_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Pino_Skill)]
	public class Mon_Pino_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Siauliai_beetle_Attack1)]
	public class Mon_Siauliai_beetle_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Siauliai_beetle_Attack2)]
	public class Mon_Siauliai_beetle_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 573f;
	}

	[SkillHandler(SkillId.Mon_Siauliai_beetle_Skill)]
	public class Mon_Siauliai_beetle_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Whip_vine_Attack1)]
	public class Mon_Whip_vine_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Whip_vine_Attack2)]
	public class Mon_Whip_vine_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Whip_vine_Skill)]
	public class Mon_Whip_vine_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Wolf_statue_Attack1)]
	public class Mon_Wolf_statue_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Wolf_statue_Skill)]
	public class Mon_Wolf_statue_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Bokchoy_Big_Attack1)]
	public class Mon_Bokchoy_Big_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Dandel_Attack1)]
	public class Mon_Dandel_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Dandel_Attack2)]
	public class Mon_Dandel_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Dandel_Skill, SkillId.Mon_infroSalamander_Skill_1)]
	public class Mon_Dandel_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_schlesien_heavycavarly_Attack1)]
	public class Mon_schlesien_heavycavarly_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Sauga_s_Attack1)]
	public class Mon_Sauga_s_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(930);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(730);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Sauga_s_Attack2)]
	public class Mon_Sauga_s_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Sauga_s_Attack3, SkillId.Mon_ep16_1_sauga_Skill_1)]
	public class Mon_Sauga_s_Attack3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Goblin_Spear_Attack, SkillId.Mon_Popolion_Attack, SkillId.Mon_Bat_big_Skill_1, SkillId.Mon_Lapasape_Skill_1, SkillId.Mon_event_Popolion_Halloween_Skill_1, SkillId.Mon_ep12_Orc_double_axe_Skill_2)]
	public class Mon_Goblin_Spear_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_HighBube_Spear_Attack)]
	public class Mon_HighBube_Spear_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(840);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_HighBube_Archer_Attack)]
	public class Mon_HighBube_Archer_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_Goblin_Archer_Attack, SkillId.Mon_Goblin_Archer_red_Skill_1)]
	public class Mon_Goblin_Archer_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_elite_spector_F_Skill_1)]
	public class Mon_elite_spector_F_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 1f;
	}

	[SkillHandler(SkillId.Mon_Popolion_Attack2, SkillId.Mon_event_Popolion_Halloween_Skill_2)]
	public class Mon_Popolion_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Bokchoy_Attack1, SkillId.Mon_blueberrin_Skill_1)]
	public class Mon_Bokchoy_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Bokchoy_Natk_Attack1)]
	public class Mon_Bokchoy_Natk_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 7f;
		protected override float Angle { get; } = 573f;
	}

	[SkillHandler(SkillId.Mon_Bokchoy_Natk_Attack2)]
	public class Mon_Bokchoy_Natk_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 573f;
	}

	[SkillHandler(SkillId.Mon_Chupacabra_Attack, SkillId.Mon_flask_Skill_1)]
	public class Mon_Chupacabra_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_Chupacabra_Attack2)]
	public class Mon_Chupacabra_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Chupacabra_Attack3)]
	public class Mon_Chupacabra_Attack3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 573f;
	}

	[SkillHandler(SkillId.Mon_Turret_sample_Attack2, SkillId.Mon_TombLord_obj_Skill_1)]
	public class Mon_Turret_sample_Attack2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10299);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Abomination_Attack)]
	public class Mon_boss_Abomination_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_HighBube_Fighter_Attack)]
	public class Mon_HighBube_Fighter_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Barricade_thorn_Attack)]
	public class Mon_Barricade_thorn_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Silvertransporter_m_Attack, SkillId.Mon_Silvertransporter_m_Skill)]
	public class Mon_Silvertransporter_m_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 573f;
	}

	[SkillHandler(SkillId.Mon_Saurman_Spearman_Attack1, SkillId.Mon_Saurman_Spearman_Skill)]
	public class Mon_Saurman_Spearman_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Throneweaver_Skill_4)]
	public class Mon_boss_Throneweaver_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(60000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Saurman_Axeman_Attack1)]
	public class Mon_Saurman_Axeman_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Saurman_Axeman_Skill)]
	public class Mon_Saurman_Axeman_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1750);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_woodspirit_Skill_3)]
	public class Mon_boss_woodspirit_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Candle_Spider_Skill_1)]
	public class Mon_Candle_Spider_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Candle_Spider_Skill_2)]
	public class Mon_Candle_Spider_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Candle_Spider_Skill_3)]
	public class Mon_Candle_Spider_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Corpse_Flower_Skill_1)]
	public class Mon_Corpse_Flower_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Corpse_Flower_Skill_2)]
	public class Mon_Corpse_Flower_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Corpse_Flower_Skill_3)]
	public class Mon_Corpse_Flower_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Flying_Flog_Skill_1)]
	public class Mon_Flying_Flog_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(560);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(560);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Flying_Flog_Skill_3)]
	public class Mon_Flying_Flog_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(480);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(480);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Moss1_Skill_1)]
	public class Mon_Moss1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_sleep, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Moss3_Skill_1)]
	public class Mon_Moss3_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Moss3_Skill_2)]
	public class Mon_Moss3_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Hepatica_King_Skill_2)]
	public class Mon_boss_Hepatica_King_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 30)
				target.StartBuff(BuffId.Moldy_skill, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Salamion_Skill_1, SkillId.Mon_Salindy_Skill_1, SkillId.Mon_Salindy_Skill_2, SkillId.Mon_Salamion_Skill_4)]
	public class Mon_Salamion_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Salamion_Skill_2)]
	public class Mon_Salamion_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Salamion_Skill_3)]
	public class Mon_Salamion_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Salindy_Skill_3)]
	public class Mon_Salindy_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_Saloon_Skill_1)]
	public class Mon_Saloon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
			target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Saloon_Skill_2, SkillId.Mon_Saloon_Skill_3)]
	public class Mon_Saloon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
			target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Tombstone_golem_Skill_1)]
	public class Mon_Tombstone_golem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tombstone_golem_Skill_3, SkillId.Mon_ep16_1_gravegolem_Skill_3)]
	public class Mon_Tombstone_golem_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Fire_Dragon_Skill_1)]
	public class Mon_Fire_Dragon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Fire_Dragon_Skill_2)]
	public class Mon_Fire_Dragon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Big_Cockatries_Skill_2, SkillId.Mon_mythic_Big_Cockatries_Skill_2)]
	public class Mon_Big_Cockatries_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Sequoia_Skill_1)]
	public class Mon_boss_Sequoia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_hori_mage_Skill_1)]
	public class Mon_hori_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_bubbe_mage_normal_Skill_1)]
	public class Mon_bubbe_mage_normal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_bubbe_mage_normal_Skill_2, SkillId.Mon_bubbe_mage_priest_Skill_1, SkillId.Mon_panto_Gstaff_Skill_1, SkillId.Mon_panto_Gwand_Skill_2, SkillId.Mon_boss_woodspirit_Skill_4, SkillId.Mon_boss_Moldyhorn_Skill_1, SkillId.Mon_boss_Moldyhorn_Skill_3, SkillId.Mon_M_boss_woodspirit_Skill_3, SkillId.Mon_M_boss_clymen_Skill_4, SkillId.Mon_hogma_sorcerer_Skill_3, SkillId.Mon_Bagworm_Skill, SkillId.Mon_M_boss_Moldyhorn_Skill_1, SkillId.Mon_M_boss_Moldyhorn_Skill_3, SkillId.Mon_M_boss_Moldyhorn_Skill_5, SkillId.Mon_pc_summon_Lithorex_Skill_1, SkillId.Mon_pc_summon_Lithorex_Skill_2)]
	public class Mon_bubbe_mage_normal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_bubbe_mage_fire_Skill_1)]
	public class Mon_bubbe_mage_fire_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_bubbe_mage_ice_Skill_1)]
	public class Mon_bubbe_mage_ice_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.Freeze, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_bubbe_mage_priest_Skill_2)]
	public class Mon_bubbe_mage_priest_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_TombMaiden_Skill_2)]
	public class Mon_boss_TombMaiden_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Grinender_Skill_1)]
	public class Mon_boss_Grinender_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_GoblinWarrior_Skill_1)]
	public class Mon_GoblinWarrior_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_dionia_Skill_3)]
	public class Mon_boss_dionia_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_dionia_mini_Skill_1)]
	public class Mon_dionia_mini_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Lithorex_Skill_3)]
	public class Mon_boss_Lithorex_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 110f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Blind, 1, 0, TimeSpan.FromMilliseconds(7000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_bramble_mini_Skill_1)]
	public class Mon_bramble_mini_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1250);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GoblinWarrior_Skill_2)]
	public class Mon_GoblinWarrior_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_molich_Skill_3)]
	public class Mon_boss_molich_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_panto_Gstaff_Skill_2, SkillId.Mon_panto_Gwand_Skill_3)]
	public class Mon_panto_Gstaff_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_panto_Gwand_Skill_1, SkillId.Mon_Npanto_staff_Skill_2)]
	public class Mon_panto_Gwand_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Moya_Skill_1, SkillId.Mon_Moya_Skill_2, SkillId.Mon_moyabu_Skill_1)]
	public class Mon_Moya_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_moyabu_Skill_2)]
	public class Mon_moyabu_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_bavon_Skill_1)]
	public class Mon_bavon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_bavon_Skill_2)]
	public class Mon_bavon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_tanu_Skill_1)]
	public class Mon_tanu_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_tanu_Skill_2)]
	public class Mon_tanu_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Zignuts_Skill_1, SkillId.Mon_belegg_Skill_1, SkillId.Mon_Npanto_baby_Skill_1, SkillId.Mon_Npanto_baby_Skill_2, SkillId.Mon_Npanto_sword_Skill_1, SkillId.Mon_Npanto_sword_Skill_2, SkillId.Mon_goblin2_hammer_Skill_1, SkillId.Mon_GlyphRing_Skill_1, SkillId.Mon_Rudasjack_Skill_1, SkillId.Mon_Deadbornscab_green_Skill_1, SkillId.Mon_piro_Skill_2, SkillId.Mon_pampen_Skill_1, SkillId.Mon_rodetad_Skill_1, SkillId.Mon_ep16_1_glyphring_Skill_1)]
	public class Mon_Zignuts_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Zignuts_Skill_2)]
	public class Mon_Zignuts_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Moglan_Skill_1)]
	public class Mon_Moglan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Moglan_Skill_2)]
	public class Mon_Moglan_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 15f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Denden_Skill_1, SkillId.Mon_slime_elite_Skill_1)]
	public class Mon_Denden_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Denden_Skill_2)]
	public class Mon_Denden_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Doyor_Skill_1)]
	public class Mon_Doyor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Doyor_Skill_2)]
	public class Mon_Doyor_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tipio_Skill_2)]
	public class Mon_Tipio_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0.1f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Rondo_Skill_1, SkillId.Mon_Dubby_Skill_1, SkillId.Mon_Leafnut_Skill_1, SkillId.Mon_rubabos_Skill_1)]
	public class Mon_Rondo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Rondo_Skill_2)]
	public class Mon_Rondo_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Long_Arm_Skill_1)]
	public class Mon_Long_Arm_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_TerraNymph_Skill_1, SkillId.Mon_Panto_spear_Skill_1, SkillId.Mon_Panto_twinsword_Skill_1, SkillId.Mon_ep16_1_terranymph_blue_Skill_1)]
	public class Mon_TerraNymph_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_TerraNymph_Skill_2, SkillId.Mon_ep16_1_terranymph_blue_Skill_2)]
	public class Mon_TerraNymph_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Long_Arm_Skill_2)]
	public class Mon_Long_Arm_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Long_Arm_Skill_4)]
	public class Mon_Long_Arm_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_dog_of_king_Skill_2, SkillId.Mon_schlesien_guard_Skill_1)]
	public class Mon_dog_of_king_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_katacom_cemeterygolem_Skill_1)]
	public class Mon_katacom_cemeterygolem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_katacom_cemeterygolem_Skill_2)]
	public class Mon_katacom_cemeterygolem_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_katacom_cemeterygolem_Skill_3)]
	public class Mon_katacom_cemeterygolem_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_tree_toormole_Skill_1, SkillId.Mon_tombstone_turtle_Skill_1, SkillId.Mon_Tama_Skill_1)]
	public class Mon_tree_toormole_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_dog_of_king_Skill_9)]
	public class Mon_dog_of_king_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_tree_toormole_Skill_3)]
	public class Mon_tree_toormole_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_schlesien_guard_Skill_3)]
	public class Mon_schlesien_guard_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_deadbone_Skill_1)]
	public class Mon_boss_deadbone_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_debrave, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_rafflesia_Skill_1, SkillId.Mon_rafflesia_purple_Skill_2)]
	public class Mon_rafflesia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_spector_F_Skill_1, SkillId.Mon_nukarong_Skill_1, SkillId.Mon_straw_walker_Skill_1, SkillId.Mon_moringbird_Skill_1, SkillId.Mon_aklasbairn_Skill_1)]
	public class Mon_spector_F_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_BiteRegina_Skill_1)]
	public class Mon_boss_BiteRegina_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.Poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_BiteRegina_Skill_3)]
	public class Mon_boss_BiteRegina_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 40)
				target.StartBuff(BuffId.Poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Genmagnus_Skill_1)]
	public class Mon_boss_Genmagnus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Iltiswort_Skill_2)]
	public class Mon_boss_Iltiswort_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_debrave, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_lepus_Skill_1)]
	public class Mon_boss_lepus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_bebraspion_Skill_2)]
	public class Mon_boss_bebraspion_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_shock, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_bebraspion_Skill_3)]
	public class Mon_boss_bebraspion_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2450);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 65f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_chafer_Skill_1)]
	public class Mon_boss_chafer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 1f;
	}

	[SkillHandler(SkillId.Mon_boss_lecifer_Skill_1)]
	public class Mon_boss_lecifer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Rocktortuga_Skill_3, SkillId.Mon_GDB_boss_Rocktortuga_Skill_4)]
	public class Mon_boss_Rocktortuga_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_helgasercle_Skill_1)]
	public class Mon_boss_helgasercle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 75f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_helgasercle_Skill_2)]
	public class Mon_boss_helgasercle_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_helgasercle_Skill_4)]
	public class Mon_boss_helgasercle_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_rootopus_Skill_2, SkillId.Mon_AR_boss_rootopus_Skill_2)]
	public class Mon_boss_rootopus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 130f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_TreeAmbulo_Skill_1)]
	public class Mon_TreeAmbulo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Golemlet_Skill_1)]
	public class Mon_Golemlet_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_squa_Skill_1, SkillId.Mon_TEST_Goblin_Miners_Skill_1)]
	public class Mon_squa_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mirtislampa_Skill_1)]
	public class Mon_mirtislampa_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_spekull_Skill_1)]
	public class Mon_spekull_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_scab_Skill_1)]
	public class Mon_scab_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(-350);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Shredded_Skill_1)]
	public class Mon_Shredded_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0.1f;
		protected override float Width { get; } = 0.1f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Yekubite_Skill_1)]
	public class Mon_Yekubite_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(780);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(580);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_Deadbornscab_Skill_1)]
	public class Mon_Deadbornscab_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Cire_Skill_1, SkillId.Mon_Ritasfung_Skill_1, SkillId.Mon_Echad_Skill_1, SkillId.Mon_Weaver_Skill_1, SkillId.Mon_Zolem_Skill_1)]
	public class Mon_Cire_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Tisfung_Skill_1)]
	public class Mon_Tisfung_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_mushfung_Skill_1)]
	public class Mon_mushfung_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_TreeGool_Skill_1)]
	public class Mon_TreeGool_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Cyst_Skill_1)]
	public class Mon_Cyst_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_Ammon_Skill_1)]
	public class Mon_Ammon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_operor_Skill_1)]
	public class Mon_operor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Chafperor_Skill_1)]
	public class Mon_Chafperor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_RavineLerva_Skill_1)]
	public class Mon_RavineLerva_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_NetherCalf_Skill_1)]
	public class Mon_NetherCalf_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Infrogalas_Skill_1)]
	public class Mon_Infrogalas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Carnivorefung_Skill_1)]
	public class Mon_Carnivorefung_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Vesper_Skill_1)]
	public class Mon_Vesper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Karas_Skill_1)]
	public class Mon_Karas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_shtayim_Skill_1)]
	public class Mon_shtayim_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tombsinker_Skill_1)]
	public class Mon_Tombsinker_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Graztas_Skill_1)]
	public class Mon_Graztas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Abogust_Skill_1)]
	public class Mon_Abogust_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_InfroRocktor_Skill_1, SkillId.Mon_Velwriggler_Skill_1, SkillId.Mon_Siaulamb_Skill_1, SkillId.Mon_minivern_Skill_1, SkillId.Mon_InfroHoglan_Skill_1, SkillId.Mon_colistump_Skill_1, SkillId.Mon_roctor_red_Skill_1)]
	public class Mon_InfroRocktor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_InfroBurk_Skill_1)]
	public class Mon_InfroBurk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_raider_Skill_1, SkillId.Mon_Infroholder_bow_Skill_1, SkillId.Mon_Repusbunny_mage_Skill_1, SkillId.Mon_Socket_bow_Skill_1, SkillId.Mon_Colifly_bow_Skill_1, SkillId.Mon_TerraNymph_bow_Skill_1, SkillId.Mon_Rambear_bow_Skill_1, SkillId.Mon_Socket_bow_brown_Skill_1, SkillId.Mon_Wendigo_archer_Skill_1, SkillId.Mon_lapasape_mage_Skill_1, SkillId.Mon_velwriggler_mage_green_Skill_1, SkillId.Mon_ep16_1_lapasape_mage_blue_Skill_1)]
	public class Mon_raider_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mushcarfung_Skill_1)]
	public class Mon_Mushcarfung_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mandara_soldier_Skill_1, SkillId.Mon_Siaulogre_Skill_2)]
	public class Mon_Mandara_soldier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_NightMaiden_Skill_1)]
	public class Mon_NightMaiden_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ringring_Skill_1)]
	public class Mon_ringring_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_woodin_Skill_1)]
	public class Mon_woodin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_StonOrca_Skill_1, SkillId.Mon_rabbee_Skill_2, SkillId.Mon_honeymeli_Skill_1)]
	public class Mon_StonOrca_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Rajapearlite_Skill_1)]
	public class Mon_Rajapearlite_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Repusbunny_Skill_1)]
	public class Mon_Repusbunny_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Beadbird_Skill_1, SkillId.Mon_ep15_1_Pokubu_ferocious_Skill_2, SkillId.Mon_ep15_1_Goblin_Rider_Skill_1)]
	public class Mon_Beadbird_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Armory_Skill_1)]
	public class Mon_Armory_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(980);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(780);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Minelever_Skill_1, SkillId.Mon_Spion_bow_Skill_1, SkillId.Mon_Stoulet_bow_Skill_1, SkillId.Mon_minos_mage_Skill_1, SkillId.Mon_Flask_mage_Skill_1, SkillId.Mon_TerraNymph_mage_Skill_1, SkillId.Mon_stub_tree_mage_Skill_1, SkillId.Mon_goblin2_wand2_Skill_1, SkillId.Mon_Cire_bow_Skill_1, SkillId.Mon_velffigy_Skill_1, SkillId.Mon_Lapemiter_Skill_1)]
	public class Mon_Minelever_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Stoulet_Skill_1, SkillId.Mon_Rajatadpole_Skill_1, SkillId.Mon_Greentoshell_Skill_1, SkillId.Mon_Goblin_Spear_red_Skill_1, SkillId.Mon_digo_Skill_1, SkillId.Mon_Wendigo_mage_Skill_1, SkillId.Mon_VelStool_Skill_1, SkillId.Mon_wood_lwa_Skill_1, SkillId.Mon_PagSawyer_Skill_1, SkillId.Mon_PagSawyer_Skill_2, SkillId.Mon_Flamag_Skill_1, SkillId.Mon_Ponpon_Skill_1, SkillId.Mon_Folibu_Skill_1, SkillId.Mon_Gosaru_Skill_1, SkillId.Mon_Ferrot_Skill_1, SkillId.Mon_DevilLantren_Skill_1, SkillId.Mon_ET_PagSawyer_Skill_1, SkillId.Mon_ET_PagSawyer_Skill_2, SkillId.Mon_wis_Skill_1, SkillId.Mon_Rakon_Skill_1, SkillId.Mon_rockoff_Skill_1, SkillId.Mon_dorong_Skill_1, SkillId.Mon_Toothrikon_Skill_1, SkillId.Mon_rompelnuka_Skill_1, SkillId.Mon_honeyspider_Skill_1, SkillId.Mon_pumpkin_dog_Skill_1, SkillId.Mon_nacorngbug_Skill_1, SkillId.Mon_nacorngfly_Skill_1, SkillId.Mon_aklastyke_Skill_1, SkillId.Mon_cloverin_Skill_1, SkillId.Mon_fragolin_Skill_1, SkillId.Mon_chesha_papa_Skill_1, SkillId.Mon_ep16_1_greentoshell_Skill_1, SkillId.Mon_ep16_2_wis_Skill_1)]
	public class Mon_Stoulet_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Prisonfighter_Skill_1, SkillId.Mon_Prisonfighter_green_Skill_1)]
	public class Mon_Prisonfighter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Cuticle_Skill_1)]
	public class Mon_Cuticle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_yekub_Skill_1)]
	public class Mon_boss_yekub_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Aos_Soldier_Skill_1, SkillId.Mon_Aos_Soldier_Skill_2)]
	public class Mon_Aos_Soldier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Rajapearl_Skill_1)]
	public class Mon_boss_Rajapearl_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_NetherBovine_Skill_2)]
	public class Mon_boss_NetherBovine_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Achat_Skill_1, SkillId.Mon_M_boss_Achat_Skill_1, SkillId.Mon_M_boss_Shnayim_Skill_1, SkillId.Mon_AR_boss_Achat_Skill_1)]
	public class Mon_boss_Achat_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_RytaSwort_Skill_1)]
	public class Mon_boss_RytaSwort_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Caro_Skill_2)]
	public class Mon_Caro_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_maggot_Skill_1)]
	public class Mon_maggot_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Drapeliun_Skill_1)]
	public class Mon_boss_Drapeliun_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Ironbaum_Skill_1)]
	public class Mon_boss_Ironbaum_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Carnivore_Skill_4)]
	public class Mon_boss_Carnivore_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Ravinepede_Skill_2, SkillId.Mon_boss_Ravinepede_Skill_4)]
	public class Mon_boss_Ravinepede_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Kimeleech_Skill_1)]
	public class Mon_boss_Kimeleech_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Kimeleech_Skill_3)]
	public class Mon_boss_Kimeleech_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Stun, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_bubbe_chaser_Skill_1)]
	public class Mon_bubbe_chaser_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_boss_Naktis_Skill_4)]
	public class Mon_boss_Naktis_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_boss_Devilglove_Skill_1)]
	public class Mon_boss_Devilglove_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Kerberos_Skill_1)]
	public class Mon_boss_Kerberos_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_Minotaurs_Skill_1)]
	public class Mon_boss_Minotaurs_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_jellyfish_Skill_1)]
	public class Mon_jellyfish_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(150);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_shock, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Sparnicht_Skill_1)]
	public class Mon_Sparnicht_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_boss_Confinedion_Skill_2, SkillId.Mon_boss_Confinedion_Skill_5)]
	public class Mon_boss_Confinedion_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_moa_Skill_2)]
	public class Mon_boss_moa_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_moa_Skill_3)]
	public class Mon_boss_moa_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_boss_bramble_Skill_2)]
	public class Mon_boss_bramble_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_bramble_Skill_3, SkillId.Mon_weekly_boss_bramble_Skill_3, SkillId.Mon_field_boss_bramble_Skill_3)]
	public class Mon_boss_bramble_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3050);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2850);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 600f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Deathweaver_Skill_1)]
	public class Mon_boss_Deathweaver_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Templeshooter_Skill_1)]
	public class Mon_boss_Templeshooter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 30)
				target.StartBuff(BuffId.UC_debrave, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Templeshooter_Skill_2, SkillId.Mon_ET_boss_Templeshooter_Skill_2)]
	public class Mon_boss_Templeshooter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_boss_Deathweaver_Skill_4)]
	public class Mon_boss_Deathweaver_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 110f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Lithorex_Skill_1)]
	public class Mon_boss_Lithorex_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Gorgon_Skill_1)]
	public class Mon_boss_Gorgon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1150);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Mummyghast_Skill_1)]
	public class Mon_boss_Mummyghast_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Mummyghast_Skill_3)]
	public class Mon_boss_Mummyghast_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 150f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_thornr_raider_Skill_1)]
	public class Mon_thornr_raider_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1080);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(780);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ellom_Skill_1, SkillId.Mon_ellom_green_Skill_1)]
	public class Mon_ellom_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ellom_Skill_2, SkillId.Mon_ellom_green_Skill_2)]
	public class Mon_ellom_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_hogma_warrior_Skill_1, SkillId.Mon_wizards_marmotte_Skill_1)]
	public class Mon_hogma_warrior_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_hogma_archer_Skill_1)]
	public class Mon_hogma_archer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_hogma_sorcerer_Skill_1, SkillId.Mon_ep16_1_hogma_sorcerer_Skill_1)]
	public class Mon_hogma_sorcerer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_merog_wizzard_Skill_1)]
	public class Mon_merog_wizzard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_merog_wogu_Skill_1)]
	public class Mon_merog_wogu_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_merog_wizzard_Skill_2)]
	public class Mon_merog_wizzard_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_hogma_warrior_Skill_2)]
	public class Mon_hogma_warrior_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_warleader_hogma_Skill_1)]
	public class Mon_warleader_hogma_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_warleader_hogma_Skill_2)]
	public class Mon_warleader_hogma_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Lizardman_Skill_1)]
	public class Mon_Lizardman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_chupaluka_Skill_1, SkillId.Mon_dimmer_Skill_1)]
	public class Mon_chupaluka_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ellomago_Skill_1)]
	public class Mon_ellomago_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_ellomago_Skill_2)]
	public class Mon_ellomago_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ellogua_Skill_1)]
	public class Mon_ellogua_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_wendigo_Skill_1, SkillId.Mon_ep13_2_wendigo_dump_Skill_1)]
	public class Mon_wendigo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_wendigo_Skill_2)]
	public class Mon_wendigo_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Lizardman_Skill_2)]
	public class Mon_Lizardman_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Kepari_Skill_1)]
	public class Mon_Kepari_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_Kepari_Skill_2)]
	public class Mon_Kepari_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_kodomor_Skill_1, SkillId.Mon_kowak_Skill_2)]
	public class Mon_kodomor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kodomor_Skill_2)]
	public class Mon_kodomor_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kowak_Skill_1, SkillId.Mon_Siaulav_Skill_2, SkillId.Mon_mythic_Siaulav_Skill_2)]
	public class Mon_kowak_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_groll_Skill_1)]
	public class Mon_groll_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_groll_Skill_2)]
	public class Mon_groll_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_chupaluka_Skill_2)]
	public class Mon_chupaluka_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tama_Skill_2)]
	public class Mon_Tama_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Scarecrow_Skill_1)]
	public class Mon_Scarecrow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_schlesien_darkmage_Skill_1)]
	public class Mon_schlesien_darkmage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_schlesien_darkmage_Skill_2)]
	public class Mon_schlesien_darkmage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Lemur_Skill_1, SkillId.Mon_Lemuria_Skill_1)]
	public class Mon_Lemur_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Lemur_Skill_2)]
	public class Mon_Lemur_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Lemuria_Skill_2)]
	public class Mon_Lemuria_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_Hogma_combat_Skill_1)]
	public class Mon_Hogma_combat_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Hogma_combat_Skill_2)]
	public class Mon_Hogma_combat_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Hogma_guard_Skill_1)]
	public class Mon_Hogma_guard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_Hogma_guard_Skill_2)]
	public class Mon_Hogma_guard_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_boss_hydra_Skill_2)]
	public class Mon_boss_hydra_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_boss_Rocktortuga_TEST_Skill_1)]
	public class Mon_boss_Rocktortuga_TEST_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 66f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_boss_Colimencia_Skill_1)]
	public class Mon_boss_Colimencia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_stub_tree_Skill_1)]
	public class Mon_stub_tree_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Clymen_Skill_3, SkillId.Mon_boss_Clymen_Skill_4)]
	public class Mon_boss_Clymen_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(60000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_hook_Skill_1)]
	public class Mon_hook_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Mon_Atk_down, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_hook_Skill_2)]
	public class Mon_hook_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_hook_Skill_3)]
	public class Mon_hook_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_JackO_lantern_Skill_1, SkillId.Mon_M_boss_jackO_lantern_Skill_1)]
	public class Mon_boss_JackO_lantern_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Chapparition_Skill_5)]
	public class Mon_boss_Chapparition_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 120f;
		protected override float Angle { get; } = 35f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_curse, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Mothstem_Skill_1)]
	public class Mon_boss_Mothstem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.ElectricShock, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_GazingGolem_Skill_1)]
	public class Mon_boss_GazingGolem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 95f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Manticen_Skill_1, SkillId.Mon_M_boss_Manticen_Skill_1, SkillId.Mon_GFB_boss_Manticen_Skill_1)]
	public class Mon_boss_Manticen_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Velorchard_Skill_1, SkillId.Mon_M_boss_Velorchard_Skill_1)]
	public class Mon_boss_Velorchard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Shnayim_Skill_1)]
	public class Mon_boss_Shnayim_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_GiantWoodGoblin_Skill_2)]
	public class Mon_boss_GiantWoodGoblin_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_Moldyhorn_Skill_5)]
	public class Mon_boss_Moldyhorn_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_varv_Skill_1)]
	public class Mon_varv_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_flight_hope_Skill_1)]
	public class Mon_flight_hope_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_flight_hope_Skill_2)]
	public class Mon_flight_hope_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_hook_red_Skill_1)]
	public class Mon_hook_red_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_hook_red_Skill_2)]
	public class Mon_hook_red_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_hook_red_Skill_3)]
	public class Mon_hook_red_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_arma_Skill_1)]
	public class Mon_arma_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Fire, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_arma_Skill_2)]
	public class Mon_arma_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_flask_Skill_2)]
	public class Mon_flask_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_tower_of_firepuppet_black_Skill_1)]
	public class Mon_tower_of_firepuppet_black_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_tower_of_firepuppet_black_Skill_2)]
	public class Mon_tower_of_firepuppet_black_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Sequoia_mini_Skill_1)]
	public class Mon_Sequoia_mini_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 5f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Whip_vine_Ra_Skill_1)]
	public class Mon_Whip_vine_Ra_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Trap_Desmodus_Skill_1)]
	public class Mon_Trap_Desmodus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Trap_ellomago_Skill_1)]
	public class Mon_Trap_ellomago_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_Dubby_Skill_2)]
	public class Mon_Dubby_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Leafnut_Skill_2)]
	public class Mon_Leafnut_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Panto_spear_Skill_2)]
	public class Mon_Panto_spear_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_Spector_F_Skill_1, SkillId.Mon_pc_summon_boss_Spector_F_Skill_1, SkillId.Mon_uniq_id_boss_Spector_F_Skill_1)]
	public class Mon_boss_Spector_F_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Panto_Rspear_Skill_1)]
	public class Mon_Panto_Rspear_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_Panto_Rspear_Skill_2, SkillId.Mon_Wolf_statue_mage_Attack2, SkillId.Mon_aklascenser_Skill_1, SkillId.Mon_bumble_green_Skill_1)]
	public class Mon_Panto_Rspear_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Panto_Bsword_Skill_1, SkillId.Mon_Panto_Bsword_Skill_2)]
	public class Mon_Panto_Bsword_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Ultanun_Skill_1, SkillId.Mon_woodgoblin_black_Skill_1, SkillId.Mon_PrisonOfficer_Skill_1)]
	public class Mon_Ultanun_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_rubabos_Skill_2)]
	public class Mon_rubabos_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Merge_Skill_1)]
	public class Mon_boss_Merge_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_shock, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Merge_Skill_2)]
	public class Mon_boss_Merge_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0.1f;
		protected override float Width { get; } = 0.1f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_bound, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Velhider_Skill_1)]
	public class Mon_Velhider_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(720);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(520);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_summons_zombie_Skill_1)]
	public class Mon_summons_zombie_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(150);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mally_Skill_1)]
	public class Mon_Mally_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Mally_Skill_2)]
	public class Mon_Mally_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Mallardu_Skill_1)]
	public class Mon_Mallardu_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Grummer_Skill_1, SkillId.Mon_event_Grummer_Skill_1)]
	public class Mon_Grummer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Humming_bud_Skill_1, SkillId.Mon_defender_spider_Skill_1, SkillId.Mon_pumpflap_Skill_1, SkillId.Mon_rabbee_Skill_1, SkillId.Mon_mon_paladin_follower2_1_Skill_1, SkillId.Mon_Boss_ebonypawn_Skill_1, SkillId.Mon_Little_rubeta_Skill_1, SkillId.Mon_nolimaid_Skill_1, SkillId.Mon_ep12_Zima_Skill_1, SkillId.Mon_boss_Bounty_Skill_1)]
	public class Mon_Humming_bud_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Humming_bud_Skill_2)]
	public class Mon_Humming_bud_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 40f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Leafly_Skill_1)]
	public class Mon_Leafly_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Leafly_Skill_2)]
	public class Mon_Leafly_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_chupacabra_desert_Skill_2, SkillId.Mon_Mentiwood_Skill_2, SkillId.Mon_ep16_1_chupacabra_desert_Skill_2)]
	public class Mon_chupacabra_desert_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Unknocker_Skill_4, SkillId.Mon_boss_capria_Skill_4, SkillId.Mon_boss_Grimreaper_Q2_Skill_5)]
	public class Mon_boss_Unknocker_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(100199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_StonOrca_Skill_2)]
	public class Mon_StonOrca_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Wolf_statue_mage_Attack1)]
	public class Mon_Wolf_statue_mage_Attack1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Wolf_statue_mage_Skill)]
	public class Mon_Wolf_statue_mage_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_hogma_warrior_Skill_3)]
	public class Mon_hogma_warrior_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_InfroBurk_Skill_2, SkillId.Mon_Lapezard_Skill_2, SkillId.Mon_mythic_Lapezard_Skill_2)]
	public class Mon_InfroBurk_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Karas_Skill_2)]
	public class Mon_Karas_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Mon_Def_down, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_wendigo_Skill_3)]
	public class Mon_wendigo_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Chromadog_Skill_1)]
	public class Mon_Chromadog_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_seedmia_Skill_2)]
	public class Mon_seedmia_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Galok_Skill_1)]
	public class Mon_Galok_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 65f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Upent_Skill_1)]
	public class Mon_Upent_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 25)
				target.StartBuff(BuffId.Freeze, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Upent_Skill_2)]
	public class Mon_Upent_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 25)
				target.StartBuff(BuffId.Freeze, 1, 0, TimeSpan.FromMilliseconds(2000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Rodelin_Skill_1, SkillId.Mon_chesha_riel_Skill_1)]
	public class Mon_Rodelin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Glizardon_Skill_3)]
	public class Mon_Glizardon_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Corylus_Skill_1)]
	public class Mon_Corylus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Corylus_Skill_2)]
	public class Mon_Corylus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Rudas_loxodon_Skill_1)]
	public class Mon_Rudas_loxodon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Rudas_loxodon_Skill_2)]
	public class Mon_Rudas_loxodon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Beeteros_Skill_1, SkillId.Mon_Mentiwood_Skill_3, SkillId.Mon_event_Beeteros_Skill_1)]
	public class Mon_Beeteros_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Beeteros_Skill_2)]
	public class Mon_Beeteros_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Mentiwood_Skill_1)]
	public class Mon_Mentiwood_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Egnome_Skill_1)]
	public class Mon_Egnome_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Egnome_Skill_2, SkillId.Mon_Egnome_yellow_Skill_2)]
	public class Mon_Egnome_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Beetow_Skill_1)]
	public class Mon_Beetow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Pawndel_Skill_1)]
	public class Mon_Pawndel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Carcashu_Skill_1)]
	public class Mon_Carcashu_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_colitile2_Skill_1, SkillId.Mon_ET_boss_ginklas_minimal_Skill_1, SkillId.Mon_vesperia_Skill_1, SkillId.Mon_ignas_summon_vesperia_Skill_1)]
	public class Mon_colitile2_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Firent_Skill_1)]
	public class Mon_Firent_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Mushcarfung_small_Skill_1)]
	public class Mon_Mushcarfung_small_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_M_boss_Glass_mole_Skill_2)]
	public class Mon_M_boss_Glass_mole_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(4000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Lichenclops_Skill_1, SkillId.Mon_Dumaro_Skill_1, SkillId.Mon_ticen_Skill_1, SkillId.Mon_Pendinmire_Skill_1, SkillId.Mon_ep16_1_ticen_Skill_1)]
	public class Mon_Lichenclops_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_tucen_Skill_1, SkillId.Mon_mythic_tucen_Skill_1, SkillId.Mon_ep16_1_tucen_Skill_1)]
	public class Mon_tucen_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Siaulago_Skill_1)]
	public class Mon_Siaulago_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Siaumire_Skill_1)]
	public class Mon_Siaumire_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Cronewt_Skill_1, SkillId.Mon_Big_Siaulamb_Skill_1)]
	public class Mon_Cronewt_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_infro_Blud_Skill_1)]
	public class Mon_infro_Blud_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_leaf_diving_Skill_1, SkillId.Mon_event_leaf_diving_Skill_1)]
	public class Mon_leaf_diving_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Hanaming_Skill_1)]
	public class Mon_Hanaming_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Quartz_Weaver_Skill_1)]
	public class Mon_Quartz_Weaver_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Fisherman_red_Skill_1)]
	public class Mon_Fisherman_red_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_duckey_Skill_1)]
	public class Mon_duckey_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_duckey_Skill_2)]
	public class Mon_duckey_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Large_crossbow_Skill_1)]
	public class Mon_Large_crossbow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 180f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Big_Siaulamb_Skill_2)]
	public class Mon_Big_Siaulamb_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Siaulogre_Skill_1)]
	public class Mon_Siaulogre_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_yognome_Skill_1)]
	public class Mon_yognome_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_pawnd_Skill_1)]
	public class Mon_pawnd_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Pendinmire_Skill_2)]
	public class Mon_Pendinmire_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_puragi_green_Skill_1, SkillId.Mon_puragi_green_Skill_3)]
	public class Mon_puragi_green_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_zinutekas_Skill_2)]
	public class Mon_zinutekas_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ROG_master_Skill_1, SkillId.Mon_HUT_master_Skill_1, SkillId.Mon_SCT_master_Skill_1)]
	public class Mon_ROG_master_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(480);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(280);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_mushroom_boy_red_Skill_1)]
	public class Mon_mushroom_boy_red_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mushroom_boy_red_Skill_3)]
	public class Mon_mushroom_boy_red_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pappus_kepa_red_Skill_1)]
	public class Mon_pappus_kepa_red_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_arburn_pokubu_green_Skill_1, SkillId.Mon_arburn_pokubu_blue_Skill_1)]
	public class Mon_arburn_pokubu_green_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_tower_of_firepuppet_Skill_1)]
	public class Mon_tower_of_firepuppet_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_tower_of_firepuppet_Skill_2)]
	public class Mon_tower_of_firepuppet_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_hori_warrior_Skill_1)]
	public class Mon_hori_warrior_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_hori_warrior_Skill_2)]
	public class Mon_hori_warrior_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mushroom_ent_black_Skill_3)]
	public class Mon_mushroom_ent_black_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_new_desmodus_black_Skill_1)]
	public class Mon_new_desmodus_black_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_LIN_master_Skill_1)]
	public class Mon_LIN_master_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_WUG_master_Skill_1)]
	public class Mon_WUG_master_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(480);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(280);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Goblin_Miners_Attack)]
	public class Mon_Goblin_Miners_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(920);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(720);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Spector_Gh_Attack)]
	public class Mon_Spector_Gh_Attack : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Spector_Gh_Skill)]
	public class Mon_Spector_Gh_Skill : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Chafer_Skill_1, SkillId.Mon_boss_Chafer_Q1_Skill_1, SkillId.Mon_GFB_boss_chafer_Skill_5)]
	public class Mon_F_boss_Chafer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 1f;
	}

	[SkillHandler(SkillId.Mon_ID_boss_Kerberos_Skill_1)]
	public class Mon_ID_boss_Kerberos_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_flame, 1, 20, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ID_boss_Kerberos_Skill_2)]
	public class Mon_ID_boss_Kerberos_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_flame, 1, 20, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ID_boss_Kerberos_Skill_6, SkillId.Mon_F_boss_Kerberos_Skill_6)]
	public class Mon_ID_boss_Kerberos_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_F_boss_BiteRegina_Skill_1)]
	public class Mon_F_boss_BiteRegina_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.Stun, 200, 0, TimeSpan.FromMilliseconds(3500), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_F_boss_BiteRegina_Skill_3)]
	public class Mon_F_boss_BiteRegina_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 60)
				target.StartBuff(BuffId.Poison_Mon, 500, 0, TimeSpan.FromMilliseconds(15000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_mon_paladin_follower1_1_Skill_1, SkillId.Mon_mon_intermediate_officer_men2_Skill_1)]
	public class Mon_mon_paladin_follower1_1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_belegg_Skill_2)]
	public class Mon_belegg_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_panto_javelin_elite_Skill_1)]
	public class Mon_panto_javelin_elite_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_colimen_Skill_1, SkillId.Mon_moringaga_Skill_2)]
	public class Mon_colimen_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_loftlem_Skill_1, SkillId.Mon_Triffid_Skill_1, SkillId.Mon_LapeArcher_Skill_1)]
	public class Mon_loftlem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_woodspirit_Skill_5)]
	public class Mon_boss_woodspirit_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_spector_gh_Skill_1)]
	public class Mon_boss_spector_gh_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Rajatoad_Skill_4)]
	public class Mon_boss_Rajatoad_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_bearkaras_Skill_2)]
	public class Mon_boss_bearkaras_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_capria_Skill_5)]
	public class Mon_boss_capria_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Denoptic_Skill_6)]
	public class Mon_boss_Denoptic_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2116);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1816);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_werewolf_Skill_5, SkillId.Mon_ID_boss_werewolf_Skill_5)]
	public class Mon_boss_werewolf_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_boss_Templeshooter_Skill_5)]
	public class Mon_boss_Templeshooter_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_FD_boss_Chapparition_Skill_6)]
	public class Mon_FD_boss_Chapparition_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(100199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_poata_Q1_Skill_4)]
	public class Mon_boss_poata_Q1_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Throneweaver_Q1_Skill_4)]
	public class Mon_boss_Throneweaver_Q1_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_spector_gh_Skill_4)]
	public class Mon_boss_spector_gh_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_woodhoungan_Skill_1)]
	public class Mon_boss_woodhoungan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_woodhoungan_Skill_2)]
	public class Mon_boss_woodhoungan_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 120f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_velpede_Skill_1)]
	public class Mon_boss_velpede_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Yeti_Skill_1)]
	public class Mon_boss_Yeti_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Yeti_Skill_3)]
	public class Mon_boss_Yeti_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 120f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Riteris_Skill_1, SkillId.Mon_ET_Silva_griffin_minimal_Skill_1, SkillId.Mon_ep13_liepsna_invader_Skill_1)]
	public class Mon_Riteris_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Kepo_seed_Skill_1)]
	public class Mon_Kepo_seed_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_BiteRegina_Skill_6)]
	public class Mon_boss_BiteRegina_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_JincanGu_Worm_Skill_1)]
	public class Mon_JincanGu_Worm_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Teraox_Skill_1)]
	public class Mon_Teraox_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Teraox_Skill_2)]
	public class Mon_Teraox_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Gremlin_Skill_1)]
	public class Mon_boss_Gremlin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 33)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(11000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_loftlem_blue_Skill_1)]
	public class Mon_loftlem_blue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Colifly_Skill_1)]
	public class Mon_Colifly_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Glackuman_Skill_1)]
	public class Mon_boss_Glackuman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Fireload_Skill_1)]
	public class Mon_boss_Fireload_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_succubus_Skill_1, SkillId.Mon_ep12_Orc_leader_Skill_2)]
	public class Mon_boss_succubus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_succubus_Skill_3)]
	public class Mon_boss_succubus_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Triffid_Skill_2)]
	public class Mon_Triffid_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_glutton_Skill_1, SkillId.Mon_boss_Blud_Skill_1)]
	public class Mon_boss_glutton_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_glutton_Skill_2)]
	public class Mon_boss_glutton_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_stun, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Crocoman_Skill_1, SkillId.Mon_ferret_patter_Skill_1, SkillId.Mon_lampal_Skill_1, SkillId.Mon_vilkas_soldier_Skill_1, SkillId.Mon_vilkas_soldier_Skill_2, SkillId.Mon_ep16_2_lampal_Skill_1)]
	public class Mon_Crocoman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Crocoman_Skill_2, SkillId.Mon_goblin2_sword_Skill_1, SkillId.Mon_rodenarcorng_Skill_2)]
	public class Mon_Crocoman_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_eldigo_Skill_1, SkillId.Mon_Templeslave_mage_Skill_1, SkillId.Mon_PagNurse_Skill_1, SkillId.Mon_Flamme_priest_Skill_1, SkillId.Mon_WatchDog_Skill_1)]
	public class Mon_eldigo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Gazing_Golem_yellow_Skill_1)]
	public class Mon_Gazing_Golem_yellow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Nuaelle_Skill_1, SkillId.Mon_flamel_Skill_1)]
	public class Mon_boss_Nuaelle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_NetherBovine_Skill_1)]
	public class Mon_pc_summon_NetherBovine_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_NetherBovine_Skill_2)]
	public class Mon_pc_summon_NetherBovine_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Genmagnus_Skill_1)]
	public class Mon_pc_summon_Genmagnus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Genmagnus_Skill_2)]
	public class Mon_pc_summon_Genmagnus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 100f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.Freeze, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_pc_summon_Mummyghast_Skill_1)]
	public class Mon_pc_summon_Mummyghast_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Mummyghast_Skill_3)]
	public class Mon_pc_summon_Mummyghast_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 150f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_slowdown, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_pc_summon_Strongholder_Skill_1)]
	public class Mon_pc_summon_Strongholder_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 55f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Strongholder_Skill_2)]
	public class Mon_pc_summon_Strongholder_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Minotaurs_Skill_1)]
	public class Mon_pc_summon_Minotaurs_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Throneweaver_Skill_3)]
	public class Mon_pc_summon_Throneweaver_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Chapparition_Skill_1)]
	public class Mon_pc_summon_Chapparition_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Blud_Skill_2, SkillId.Mon_pc_summon_boss_Blud_Skill_2)]
	public class Mon_boss_Blud_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Harpeia_Skill_1)]
	public class Mon_pc_summon_Harpeia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Taumas_Skill_1)]
	public class Mon_boss_Taumas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Velhider_Skill_2)]
	public class Mon_Velhider_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Npanto_archer_Skill_1)]
	public class Mon_Npanto_archer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Npanto_archer_Skill_2)]
	public class Mon_Npanto_archer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Npanto_staff_Skill_1)]
	public class Mon_Npanto_staff_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Templeshooter_Skill_1, SkillId.Mon_ET_boss_Templeshooter_Skill_1)]
	public class Mon_pc_summon_Templeshooter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Templeshooter_Skill_2)]
	public class Mon_pc_summon_Templeshooter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Riteris_Skill_4)]
	public class Mon_Riteris_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Riteris_Skill_1)]
	public class Mon_pc_summon_Riteris_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Zombie_hoplite_Skill_1)]
	public class Mon_Zombie_hoplite_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Zombie_hoplite_Skill_2, SkillId.Mon_vilkas_spearman_Skill_2)]
	public class Mon_Zombie_hoplite_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Echad_bow_Skill_1, SkillId.Mon_Tiny_mage_Skill_1, SkillId.Mon_Tiny_bow_Skill_1, SkillId.Mon_wolf_statue_bow_Skill_1, SkillId.Mon_shtayim_mage_Skill_1, SkillId.Mon_wolf_statue_magician_Skill_1, SkillId.Mon_goblin2_wand3_Skill_1, SkillId.Mon_jukotail_Skill_1, SkillId.Mon_pyran_green_Skill_1, SkillId.Mon_velwriggler_mage_red_Skill_1, SkillId.Mon_velaphid_red_Skill_1, SkillId.Mon_Stonacorn_Skill_1, SkillId.Mon_Glyquare_Skill_1, SkillId.Mon_Glyquare_red_Skill_1, SkillId.Mon_piang_Skill_1)]
	public class Mon_Echad_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Hallowventor_mage_Skill_2, SkillId.Mon_Deadbornscab_mage_Skill_1, SkillId.Mon_Deadbornscab_bow_Skill_1, SkillId.Mon_Siaulav_mage_Skill_1, SkillId.Mon_Siaulav_bow_Skill_1, SkillId.Mon_Spion_mage_Skill_1, SkillId.Mon_Stoulet_mage_Skill_1, SkillId.Mon_Kepari_mage_Skill_1, SkillId.Mon_mythic_Hallowventor_mage_Skill_1)]
	public class Mon_Hallowventor_mage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Hallowventor_bow_Skill_1)]
	public class Mon_Hallowventor_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Hallowventor_bow_Skill_2)]
	public class Mon_Hallowventor_bow_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Templeslave_mage_Skill_2)]
	public class Mon_Templeslave_mage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Infroholder_mage_Skill_1, SkillId.Mon_Infrogalas_mage_Skill_1)]
	public class Mon_Infroholder_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Infroholder_mage_Skill_2)]
	public class Mon_Infroholder_mage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Infroholder_bow_Skill_2)]
	public class Mon_Infroholder_bow_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_velnewt_Skill_2)]
	public class Mon_boss_velnewt_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Repusbunny_bow_Skill_1)]
	public class Mon_Repusbunny_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Repusbunny_bow_Skill_2)]
	public class Mon_Repusbunny_bow_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 5f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_plokste_Skill_1)]
	public class Mon_boss_plokste_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Basilisk_Skill_1)]
	public class Mon_boss_Basilisk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_debrave, 1, 0, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Basilisk_Skill_2)]
	public class Mon_boss_Basilisk_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 30)
				target.StartBuff(BuffId.UC_debrave, 1, 0, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_velpede_Skill_2, SkillId.Mon_GRB_boss_velpede_Skill_2)]
	public class Mon_boss_velpede_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_LumberPus_Skill_1)]
	public class Mon_boss_LumberPus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_LumberPus_Skill_4)]
	public class Mon_boss_LumberPus_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_nuodai_Skill_1)]
	public class Mon_boss_nuodai_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Centaurus_Skill_1)]
	public class Mon_boss_Centaurus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Turtai_Skill_1)]
	public class Mon_boss_Turtai_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Turtai_Skill_2)]
	public class Mon_boss_Turtai_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Turtai_Skill_3)]
	public class Mon_boss_Turtai_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_Crabil_Skill_1)]
	public class Mon_boss_Crabil_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 25)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Crabil_Skill_2)]
	public class Mon_boss_Crabil_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(7000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Neop_Skill_1)]
	public class Mon_boss_Neop_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Belian_Skill_1)]
	public class Mon_boss_Belian_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Siaulav_mage_Skill_2)]
	public class Mon_Siaulav_mage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tiny_bow_Skill_2)]
	public class Mon_Tiny_bow_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Spion_mage_Skill_2)]
	public class Mon_Spion_mage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_minos_bow_Skill_1, SkillId.Mon_Chafperor_mage_Skill_1, SkillId.Mon_Sowpent_Skill_1, SkillId.Mon_Hohen_mane_Skill_1, SkillId.Mon_hohen_barkle_Skill_1, SkillId.Mon_Flamme_archer_Skill_1, SkillId.Mon_tala_sorcerer_Skill_1, SkillId.Mon_bishop_blanco_Skill_1)]
	public class Mon_minos_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Wendigo_bow_Skill_1, SkillId.Mon_lapasape_bow_Skill_1, SkillId.Mon_Socket_mage_Skill_1, SkillId.Mon_Colifly_mage_Skill_1, SkillId.Mon_Lichenclops_mage_Skill_1, SkillId.Mon_goblin2_wand1_Skill_1, SkillId.Mon_NightMaiden_mage_Skill_1, SkillId.Mon_NightMaiden_bow_Skill_1, SkillId.Mon_Rambear_mage_Skill_1, SkillId.Mon_pyran_Skill_1, SkillId.Mon_Elet_Skill_1, SkillId.Mon_mythic_NightMaiden_mage_Skill_1, SkillId.Mon_mythic_NightMaiden_bow_Skill_1, SkillId.Mon_mythic_pyran_Skill_1)]
	public class Mon_Wendigo_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_saltisdaughter_bow_Skill_1, SkillId.Mon_Infrogalas_bow_Skill_1, SkillId.Mon_ticen_bow_Skill_1, SkillId.Mon_ID_Malstatue_Skill_1)]
	public class Mon_saltisdaughter_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Cronewt_bow_Skill_1)]
	public class Mon_Cronewt_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Cire_mage_Skill_1, SkillId.Mon_Karas_mage_Skill_1, SkillId.Mon_blok_wizard_Skill_1, SkillId.Mon_ep12_Orc_cannon_Skill_1)]
	public class Mon_Cire_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Infrogalas_mage_Skill_2)]
	public class Mon_Infrogalas_mage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Lizardman_mage_Skill_1)]
	public class Mon_Lizardman_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(1000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_goblin2_hammer_Skill_2, SkillId.Mon_Elma_Skill_1)]
	public class Mon_goblin2_hammer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_goblin2_axe_Skill_1)]
	public class Mon_goblin2_axe_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_colimen_mage_Skill_1, SkillId.Mon_Legend_boss_Pbeta_Skill_15, SkillId.Mon_Legend_boss_Pbeta_Solo_Skill_15)]
	public class Mon_colimen_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Cronewt_mage_Skill_1)]
	public class Mon_Cronewt_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_velffigy_green_Skill_1)]
	public class Mon_velffigy_green_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_anchor_mage_Skill_1, SkillId.Mon_Romor_Skill_1, SkillId.Mon_velpod_Skill_1)]
	public class Mon_anchor_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_anchor_Skill_1, SkillId.Mon_anchor_purple_Skill_1)]
	public class Mon_anchor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Nnuo_Skill_1, SkillId.Mon_pennamayo_Skill_1, SkillId.Mon_ep14_1_Bleakferret_Spear_Skill_2)]
	public class Mon_Nnuo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Nnuo_Skill_2)]
	public class Mon_Nnuo_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Nuka_Skill_1)]
	public class Mon_Nuka_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Nuka_Skill_2, SkillId.Mon_charog_Skill_1)]
	public class Mon_Nuka_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_defender_spider_Skill_2)]
	public class Mon_defender_spider_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Pandroceum_Skill_1, SkillId.Mon_Toothrikon_Skill_2, SkillId.Mon_poncer_Skill_1)]
	public class Mon_Pandroceum_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Drapel_Skill_1)]
	public class Mon_Drapel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Mandara_Skill_1)]
	public class Mon_boss_Mandara_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1150);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Mandara_Skill_3)]
	public class Mon_boss_Mandara_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ticen_mage_Skill_1)]
	public class Mon_ticen_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Dionys_Q1_Skill_1)]
	public class Mon_boss_Dionys_Q1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_loftlem_green_Skill_1, SkillId.Mon_ghoscandle_Skill_1)]
	public class Mon_loftlem_green_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Colifly_violet_Skill_1, SkillId.Mon_Colifly_yellow_Skill_1)]
	public class Mon_Colifly_violet_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Egnome_yellow_Skill_1)]
	public class Mon_Egnome_yellow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_lantern_mushroom_orange_Skill_2)]
	public class Mon_lantern_mushroom_orange_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 1f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_sleep, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Deadbornscab_bow_green_Skill_1)]
	public class Mon_Deadbornscab_bow_green_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Cronewt_bow_brown_Skill_1)]
	public class Mon_Cronewt_bow_brown_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Colifly_bow_purple_Skill_1)]
	public class Mon_Colifly_bow_purple_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Moss_purple_Skill_1)]
	public class Mon_Moss_purple_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_sleep, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Hohen_ritter_Skill_1, SkillId.Mon_ep12_Wolf_Skill_1)]
	public class Mon_Hohen_ritter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Hohen_ritter_Skill_2)]
	public class Mon_Hohen_ritter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Hohen_mage_Skill_1, SkillId.Mon_Hohen_orben_Skill_1, SkillId.Mon_mythic_Hohen_orben_Skill_1)]
	public class Mon_Hohen_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Harugal_Skill_1, SkillId.Mon_ep12_vilktis_Skill_1)]
	public class Mon_Harugal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Fireload_Skill_1)]
	public class Mon_pc_summon_Fireload_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Glackuman_Skill_1)]
	public class Mon_pc_summon_Glackuman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Deathweaver_Skill_1)]
	public class Mon_pc_summon_Deathweaver_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_archon_Skill_1)]
	public class Mon_pc_summon_archon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Kerberos_Skill_1)]
	public class Mon_pc_summon_Kerberos_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 75f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Kerberos_Skill_2)]
	public class Mon_pc_summon_Kerberos_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Marionette_Skill_1)]
	public class Mon_pc_summon_Marionette_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_durahan_Skill_1)]
	public class Mon_pc_summon_durahan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 75f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ID_Banshee_pink_Skill_1)]
	public class Mon_ID_Banshee_pink_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_pc_summon_Unknocker_Skill_4)]
	public class Mon_pc_summon_Unknocker_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Nuaelle_Skill_1)]
	public class Mon_pc_summon_Nuaelle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Abomination_Skill_1)]
	public class Mon_pc_summon_Abomination_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Unknocker_Skill_5)]
	public class Mon_pc_summon_Unknocker_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_CorpseTower_Skill_1)]
	public class Mon_pcskill_CorpseTower_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_skullsoldier_Skill_1, SkillId.Mon_skullsoldier_Skill_1)]
	public class Mon_pcskill_skullsoldier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_shogogoth_Skill_1)]
	public class Mon_pcskill_shogogoth_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_shogogoth_Skill_2)]
	public class Mon_pcskill_shogogoth_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_bramble_TEST_Skill_2)]
	public class Mon_boss_bramble_TEST_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_bramble_TEST_Skill_3)]
	public class Mon_boss_bramble_TEST_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3050);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2850);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 600f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Stun, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_bramble_TEST_Skill_5)]
	public class Mon_boss_bramble_TEST_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1150);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_bramble_TEST_Skill_6, SkillId.Mon_F_boss_lecifer_Skill_4, SkillId.Mon_weekly_boss_lecifer_Skill_4, SkillId.Mon_field_boss_lecifer_Skill_4)]
	public class Mon_boss_bramble_TEST_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 200f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_bramble_TEST_Skill_7)]
	public class Mon_boss_bramble_TEST_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Gosal_Skill_1)]
	public class Mon_boss_Gosal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_npc_paladinmaster_Skill_2)]
	public class Mon_npc_paladinmaster_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(770);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(570);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ROD_master_Skill_2)]
	public class Mon_ROD_master_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_BAR_master_Skill_2)]
	public class Mon_BAR_master_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.Stun, 1, 0, TimeSpan.FromMilliseconds(2500), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Lapezard_Skill_1, SkillId.Mon_ferret_archer_Skill_1, SkillId.Mon_blok_archer_Skill_1, SkillId.Mon_budny_Skill_1, SkillId.Mon_Horong_walker_Skill_1, SkillId.Mon_mythic_Elet_Skill_1, SkillId.Mon_mythic_Lapezard_Skill_1)]
	public class Mon_Lapezard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Lapfighter_Skill_1, SkillId.Mon_bishop_gray_Skill_1)]
	public class Mon_Lapfighter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Lapfighter_Skill_2)]
	public class Mon_Lapfighter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_Lapflammer_Skill_1)]
	public class Mon_Lapflammer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ferret_archer_Skill_2)]
	public class Mon_ferret_archer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ferret_bearer_Skill_1)]
	public class Mon_ferret_bearer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ferret_folk_Skill_1)]
	public class Mon_ferret_folk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ferret_loader_Skill_1)]
	public class Mon_ferret_loader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_FerretMarauder_Skill_1, SkillId.Mon_F_boss_FerretMarauder_Skill_1)]
	public class Mon_boss_FerretMarauder_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_bone_Skill_1)]
	public class Mon_pcskill_bone_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Hexing_Debuff, 1, 0, TimeSpan.FromMilliseconds(7000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Foculus_Skill_1)]
	public class Mon_boss_Foculus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_boss_Lapene_Skill_1)]
	public class Mon_boss_Lapene_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_boss_Rocksodon_Skill_1)]
	public class Mon_boss_Rocksodon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Rocksodon_Skill_3)]
	public class Mon_boss_Rocksodon_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_PantoRex_Skill_1)]
	public class Mon_boss_PantoRex_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_Rambandgad_Skill_3)]
	public class Mon_boss_Rambandgad_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Rambandgad_Skill_5)]
	public class Mon_boss_Rambandgad_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Lapedame_Skill_3)]
	public class Mon_boss_Lapedame_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Gosal_Skill_2)]
	public class Mon_boss_Gosal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Gosarius_Skill_1)]
	public class Mon_boss_Gosarius_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_stonefroster_Skill_1)]
	public class Mon_boss_stonefroster_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 65f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_stonefroster_Skill_4)]
	public class Mon_boss_stonefroster_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 110f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_FerretMarauder_Skill_5)]
	public class Mon_boss_FerretMarauder_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_boss_Orkan_Skill_1)]
	public class Mon_boss_Orkan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ferret_searcher_Skill_1)]
	public class Mon_ferret_searcher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1150);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ferret_slinger_Skill_1)]
	public class Mon_ferret_slinger_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ferret_slinger_Skill_2)]
	public class Mon_ferret_slinger_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Velniamonkey_Skill_6)]
	public class Mon_boss_Velniamonkey_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ID_boss_Riteris_Skill_1)]
	public class Mon_ID_boss_Riteris_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ID_boss_Riteris_Skill_4)]
	public class Mon_ID_boss_Riteris_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_hauberk_Skill_1)]
	public class Mon_boss_hauberk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_charcoal_walker_Skill_1, SkillId.Mon_blueberrin_Skill_2)]
	public class Mon_charcoal_walker_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_PagWheeler_Skill_1)]
	public class Mon_PagWheeler_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_PagNanny_Skill_1, SkillId.Mon_PagEmitter_Skill_1, SkillId.Mon_PagDoper_Skill_2, SkillId.Mon_rodenarcorng_Skill_1, SkillId.Mon_delione_Skill_1)]
	public class Mon_PagNanny_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_PagNanny_Skill_2)]
	public class Mon_PagNanny_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_PagDoper_Skill_1)]
	public class Mon_PagDoper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Pagclamper_Skill_1)]
	public class Mon_Pagclamper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_Paggnat_Skill_1)]
	public class Mon_Paggnat_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Flamag_Skill_2)]
	public class Mon_Flamag_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Flak_Skill_1)]
	public class Mon_Flak_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Flak_Skill_2)]
	public class Mon_Flak_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = -5f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Flammidus_Skill_1, SkillId.Mon_ET_boss_Flammidus_Skill_1)]
	public class Mon_boss_Flammidus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Flammidus_Skill_2)]
	public class Mon_boss_Flammidus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Flammidus_Skill_4)]
	public class Mon_boss_Flammidus_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Marnoks_Skill_1)]
	public class Mon_boss_Marnoks_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Marnoks_Skill_5)]
	public class Mon_boss_Marnoks_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Zawra_Skill_1)]
	public class Mon_boss_Zawra_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_boss_Pinscher_Skill_1)]
	public class Mon_boss_Pinscher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Lapeman_Skill_1, SkillId.Mon_chesha_torso_Skill_1)]
	public class Mon_Lapeman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kenol_Skill_1, SkillId.Mon_mon_npc_tila_monk_Skill_1)]
	public class Mon_kenol_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_F_boss_helgasercle_Skill_1, SkillId.Mon_weekly_boss_helgasercle_Skill_1, SkillId.Mon_field_boss_helgasercle_Skill_1)]
	public class Mon_F_boss_helgasercle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 75f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_F_boss_helgasercle_Skill_2)]
	public class Mon_F_boss_helgasercle_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_F_boss_lecifer_Skill_1)]
	public class Mon_F_boss_lecifer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Rambandgad_Skill_3)]
	public class Mon_pc_summon_Rambandgad_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Flammidus_Skill_1)]
	public class Mon_pc_summon_Flammidus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Kerberos_Q1_Skill_1)]
	public class Mon_boss_Kerberos_Q1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_M_boss_jackO_lantern_Skill_5)]
	public class Mon_M_boss_jackO_lantern_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_M_boss_colimencia_Skill_1)]
	public class Mon_M_boss_colimencia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Pagshearer_Skill_1)]
	public class Mon_Pagshearer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 2)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Pagshearer_Skill_2)]
	public class Mon_Pagshearer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_mon_npc_sapper_Skill_1)]
	public class Mon_mon_npc_sapper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_Lithorex_Skill_3)]
	public class Mon_pc_summon_Lithorex_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 110f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_M_boss_deadbone_Skill_1, SkillId.Mon_ep12_trampled_Skill_1, SkillId.Mon_ep12_Sodininkas_Skill_1, SkillId.Mon_mythic_Hohen_ritter_Skill_1)]
	public class Mon_M_boss_deadbone_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_M_boss_GiantWoodGoblin_Skill_2)]
	public class Mon_M_boss_GiantWoodGoblin_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_M_boss_Ironbaum_Skill_1)]
	public class Mon_M_boss_Ironbaum_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_M_boss_Ironbaum_Skill_2)]
	public class Mon_M_boss_Ironbaum_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_M_boss_Denoptic_Skill_5)]
	public class Mon_M_boss_Denoptic_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_M_boss_minotaurs_Skill_1)]
	public class Mon_M_boss_minotaurs_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_M_boss_GazingGolem_Skill_1)]
	public class Mon_M_boss_GazingGolem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 95f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_rubblem_Skill_2)]
	public class Mon_rubblem_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(870);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(670);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mouse_Skill_1)]
	public class Mon_Mouse_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Slime_Skill_1)]
	public class Mon_Slime_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Torment_Skill_1)]
	public class Mon_boss_Torment_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_Ghoul_Skill_1)]
	public class Mon_Ghoul_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_MorningStarGolem_Skill_1)]
	public class Mon_MorningStarGolem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_DeathBell_Skill_1)]
	public class Mon_DeathBell_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_Glackuman_minimal_Skill_1)]
	public class Mon_ET_Glackuman_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_Canceril_minimal_Skill_1)]
	public class Mon_ET_Canceril_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_shock, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_Velniamonkey_minimal_Skill_1)]
	public class Mon_ET_Velniamonkey_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_Velniamonkey_minimal_Skill_3)]
	public class Mon_ET_Velniamonkey_minimal_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_stun, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_Foculus_minimal_Skill_1)]
	public class Mon_ET_Foculus_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_petrify, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_Rocksodon_minimal_Skill_1)]
	public class Mon_ET_Rocksodon_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ET_Silva_griffin_minimal_Skill_2)]
	public class Mon_ET_Silva_griffin_minimal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_boss_Mothstem_Skill_1, SkillId.Mon_GFB_boss_Mothstem_Skill_1)]
	public class Mon_ET_boss_Mothstem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Flammidus_Skill_2)]
	public class Mon_ET_boss_Flammidus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Flammidus_Skill_4)]
	public class Mon_ET_boss_Flammidus_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 15)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_boss_Pinscher_Skill_1)]
	public class Mon_ET_boss_Pinscher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Gosarius_Skill_1)]
	public class Mon_ET_boss_Gosarius_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Gosarius_Skill_4)]
	public class Mon_ET_boss_Gosarius_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 150f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_GRB_boss_velpede_Skill_1)]
	public class Mon_GRB_boss_velpede_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GRB_boss_velpede_Skill_4, SkillId.Mon_hafter_Skill_2)]
	public class Mon_GRB_boss_velpede_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_gear_Skill_2, SkillId.Mon_ep16_2_gear_Skill_2)]
	public class Mon_gear_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_wisnol_Skill_2, SkillId.Mon_ep16_2_wisnol_Skill_2)]
	public class Mon_wisnol_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_lapindal_Skill_1, SkillId.Mon_ep16_2_lapindal_Skill_1)]
	public class Mon_lapindal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_llapindal_ribbon_Skill_1, SkillId.Mon_ep16_2_llapindal_ribbon_Skill_1)]
	public class Mon_llapindal_ribbon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_lapindion_Skill_1, SkillId.Mon_weekly_lapindion_lucy_summon_Skill_1, SkillId.Mon_ep16_2_lapindion_Skill_1)]
	public class Mon_lapindion_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_lapindion_Skill_2, SkillId.Mon_ep16_2_lapindion_Skill_2)]
	public class Mon_lapindion_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_tala_combat_Skill_1)]
	public class Mon_tala_combat_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_tala_combat_Skill_2)]
	public class Mon_tala_combat_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_warleader_tala_Skill_1, SkillId.Mon_ERD_warleader_tala_Skill_1, SkillId.Mon_ep12_raganosis_ram_Skill_1)]
	public class Mon_warleader_tala_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Rakon_Skill_2)]
	public class Mon_Rakon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_rockon_Skill_2)]
	public class Mon_rockon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_rocktanon_Skill_1)]
	public class Mon_rocktanon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_rocktanon_Skill_2)]
	public class Mon_rocktanon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_rockoff_Skill_2)]
	public class Mon_rockoff_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_dorong_Skill_2)]
	public class Mon_dorong_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_debrave, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_dorong_Skill_3, SkillId.Mon_pingping_Skill_1)]
	public class Mon_dorong_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_kurmis_Skill_1)]
	public class Mon_boss_kurmis_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_kurmis_Skill_2)]
	public class Mon_boss_kurmis_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.Stun, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_AWK_boss_PantoRex_Skill_1)]
	public class Mon_AWK_boss_PantoRex_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_stalakan_Skill_1)]
	public class Mon_boss_stalakan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Tetraffid_Skill_1)]
	public class Mon_Tetraffid_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Tetraffid_Skill_2)]
	public class Mon_Tetraffid_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_silence_normalAttack, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_boss_Neop_Skill_1)]
	public class Mon_ET_boss_Neop_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_spector_F_Skill_1)]
	public class Mon_ET_spector_F_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Orkan_Skill_1)]
	public class Mon_ET_boss_Orkan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_moa_minimal_Skill_1)]
	public class Mon_ET_boss_moa_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_moa_minimal_Skill_2)]
	public class Mon_ET_boss_moa_minimal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_unicorn_minimal_Skill_1)]
	public class Mon_ET_boss_unicorn_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Devilglove_minimal_Skill_1)]
	public class Mon_ET_boss_Devilglove_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_ginklas_minimal_Skill_3)]
	public class Mon_ET_boss_ginklas_minimal_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Saltistter_minimal_Skill_1)]
	public class Mon_ET_boss_Saltistter_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_boss_Velorchard_minimal_Skill_1)]
	public class Mon_ET_boss_Velorchard_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Merge_minimal_Skill_1)]
	public class Mon_ET_boss_Merge_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Merge_minimal_Skill_2)]
	public class Mon_ET_boss_Merge_minimal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_hydra_minimal_Skill_1)]
	public class Mon_ET_boss_hydra_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_hydra_minimal_Skill_2)]
	public class Mon_ET_boss_hydra_minimal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(8000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_boss_Manticen_minimal_Skill_1)]
	public class Mon_ET_boss_Manticen_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_plokste_Skill_1)]
	public class Mon_ET_boss_plokste_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Grimreaper_Skill_1)]
	public class Mon_ET_boss_Grimreaper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ET_boss_Grimreaper_Skill_5)]
	public class Mon_ET_boss_Grimreaper_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Gorgon_Skill_1)]
	public class Mon_pc_summon_boss_Gorgon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_spector_gh_Skill_2)]
	public class Mon_pc_summon_boss_spector_gh_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_spector_gh_Skill_3)]
	public class Mon_pc_summon_boss_spector_gh_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Velorchard_Skill_1)]
	public class Mon_pc_summon_boss_Velorchard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_unicorn_Skill_1)]
	public class Mon_pc_summon_boss_unicorn_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_helgasercle_Skill_1)]
	public class Mon_pc_summon_boss_helgasercle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Naktis_Skill_1)]
	public class Mon_pc_summon_boss_Naktis_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Blud_Skill_1)]
	public class Mon_pc_summon_boss_Blud_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_nuodai_Skill_1)]
	public class Mon_pc_summon_boss_nuodai_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Centaurus_Skill_1)]
	public class Mon_pc_summon_boss_Centaurus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Genmagnus_Skill_2)]
	public class Mon_pc_summon_boss_Genmagnus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 100f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Fallen_Statue_Skill_1)]
	public class Mon_pc_summon_boss_Fallen_Statue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GBT_boss_yonazolem_Skill_1)]
	public class Mon_GBT_boss_yonazolem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ET_boss_Orkan_Skill_5)]
	public class Mon_ET_boss_Orkan_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.UC_stun, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_nukarong_Skill_2, SkillId.Mon_ep12_Orc_flag_Skill_1)]
	public class Mon_nukarong_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_rompelnuka_Skill_2)]
	public class Mon_rompelnuka_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Boss_ebonypawn_Skill_5)]
	public class Mon_Boss_ebonypawn_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_vilkas_warrior_Skill_1)]
	public class Mon_vilkas_warrior_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_vilkas_spearman_Skill_1)]
	public class Mon_vilkas_spearman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_vilkas_archer_Skill_1)]
	public class Mon_vilkas_archer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_vilkas_fighter_Skill_2)]
	public class Mon_vilkas_fighter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Armaox_Skill_5)]
	public class Mon_boss_Armaox_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 5f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Velmosquy_Skill_1, SkillId.Mon_boss_Velmosquy_Q1_Skill_1)]
	public class Mon_boss_Velmosquy_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 70f;
	}

	[SkillHandler(SkillId.Mon_boss_Velmosquy_Skill_2, SkillId.Mon_boss_Velmosquy_Q1_Skill_2)]
	public class Mon_boss_Velmosquy_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Silva_griffin_Skill_1)]
	public class Mon_boss_Silva_griffin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_boss_Silva_griffin_Skill_2)]
	public class Mon_boss_Silva_griffin_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pcskill_skullarcher_Skill_1, SkillId.Mon_skullarcher_Skill_1)]
	public class Mon_pcskill_skullarcher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_kucarry_Tot_Skill_1, SkillId.Mon_ID_kucarry_Tot_Skill_1)]
	public class Mon_kucarry_Tot_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kucarry_Tot_Skill_2, SkillId.Mon_kucarry_lioni_Skill_1, SkillId.Mon_ID_kucarry_Tot_Skill_2, SkillId.Mon_ID_kucarry_lioni_Skill_1, SkillId.Mon_rabbler_Skill_1)]
	public class Mon_kucarry_Tot_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kucarry_Somy_Skill_1, SkillId.Mon_ID_kucarry_Somy_Skill_1)]
	public class Mon_kucarry_Somy_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kucarry_Somy_Skill_2, SkillId.Mon_ID_kucarry_Somy_Skill_2)]
	public class Mon_kucarry_Somy_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_kucarry_lioni_Skill_2, SkillId.Mon_ID_kucarry_lioni_Skill_2)]
	public class Mon_kucarry_lioni_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kucarry_numani_Skill_1, SkillId.Mon_kucarry_zabbi_Skill_1, SkillId.Mon_siaria_Skill_1, SkillId.Mon_ID_kucarry_zabbi_Skill_1)]
	public class Mon_kucarry_numani_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_kucarry_symbani_Skill_1)]
	public class Mon_kucarry_symbani_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_kucarry_zeuni_Skill_1, SkillId.Mon_ID_kucarry_zeuni_Skill_1)]
	public class Mon_kucarry_zeuni_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_kucarry_balzer_Skill_1)]
	public class Mon_kucarry_balzer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 8)
				target.StartBuff(BuffId.UC_silence, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_kucarry_Zeffi_Skill_2)]
	public class Mon_kucarry_Zeffi_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_castle_gardner_Skill_1)]
	public class Mon_castle_gardner_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 65f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_ragged_butcher_Skill_1, SkillId.Mon_scare_crow_Skill_1)]
	public class Mon_ragged_butcher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_ragged_bird_Skill_2)]
	public class Mon_ragged_bird_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 8f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_straw_walker_Skill_2)]
	public class Mon_straw_walker_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_florabbi_Skill_1)]
	public class Mon_florabbi_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_florabbi_Skill_2)]
	public class Mon_florabbi_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_bloom_Skill_1)]
	public class Mon_bloom_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 5f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pierrol_Skill_1)]
	public class Mon_pierrol_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pingping_Skill_2, SkillId.Mon_moringbird_Skill_2)]
	public class Mon_pingping_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_valdovas_Skill_1, SkillId.Mon_d_uniq_boss_valdovas_Skill_1)]
	public class Mon_boss_valdovas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_nacorngbug_Skill_2)]
	public class Mon_nacorngbug_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_rodenag_Skill_1)]
	public class Mon_rodenag_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_rodenag_Skill_2)]
	public class Mon_rodenag_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 65f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_elder_rode_Skill_1)]
	public class Mon_elder_rode_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 8f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_rodedoe_Skill_1)]
	public class Mon_rodedoe_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_roderiot_Skill_1)]
	public class Mon_roderiot_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(50);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_rodevassal_Skill_1)]
	public class Mon_rodevassal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mon_npc_w_hunter_Skill_1)]
	public class Mon_mon_npc_w_hunter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_glutton_Q2_Skill_1)]
	public class Mon_boss_glutton_Q2_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_froster_lord_Skill_5)]
	public class Mon_boss_froster_lord_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_nabu_Skill_1)]
	public class Mon_nabu_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_nabu_Skill_2)]
	public class Mon_nabu_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 4)
				target.StartBuff(BuffId.UC_confuse, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_darong_Skill_2, SkillId.Mon_kisylion_Skill_1)]
	public class Mon_darong_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pcskill_boss_werewolf_Skill_1)]
	public class Mon_pcskill_boss_werewolf_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Zawra_Skill_1)]
	public class Mon_F_boss_Zawra_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 140f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Nuaelle_Skill_3, SkillId.Mon_F_boss_Nuaelle_Skill_8)]
	public class Mon_F_boss_Nuaelle_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 30)
				target.StartBuff(BuffId.Mon_Magic_Shield_Debuff, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_F_boss_Zawra_Skill_5, SkillId.Mon_weekly_boss_Zawra_Skill_5, SkillId.Mon_field_boss_Zawra_Skill_5)]
	public class Mon_F_boss_Zawra_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 1f;
		protected override float Width { get; } = 1f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ID_boss_Armaox_Skill_5)]
	public class Mon_ID_boss_Armaox_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 5f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Blud_Skill_7)]
	public class Mon_F_boss_Blud_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_slowdown, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_umbra_warrior_Skill_1, SkillId.Mon_ID_umbra_warrior_Skill_1, SkillId.Mon_Lotuscat_Skill_1, SkillId.Mon_ep12_Gari_Skill_1)]
	public class Mon_umbra_warrior_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_umbra_warrior_Skill_2)]
	public class Mon_umbra_warrior_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_aklasdame_Skill_1)]
	public class Mon_aklasdame_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 8)
				target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_aklasia_Skill_1, SkillId.Mon_KindronBoor_Skill_1)]
	public class Mon_aklasia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_aklasia_Skill_2, SkillId.Mon_aklascountess_Skill_1)]
	public class Mon_aklasia_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_aklasbishop_Skill_1)]
	public class Mon_aklasbishop_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 140f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_umbra_mage_Skill_1, SkillId.Mon_ID_umbra_mage_Skill_1)]
	public class Mon_umbra_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_umblet_Skill_1, SkillId.Mon_ID_umblet_Skill_1)]
	public class Mon_umblet_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_aklaschurl_Skill_1)]
	public class Mon_aklaschurl_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pcskill_boss_werewolf_Skill_4)]
	public class Mon_pcskill_boss_werewolf_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 180f;
		protected override float Width { get; } = 75f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_confuse, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Castle_princess_Skill_2)]
	public class Mon_boss_Castle_princess_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_diena_Skill_1)]
	public class Mon_boss_diena_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_diena_Skill_3)]
	public class Mon_boss_diena_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Escarot_Skill_1)]
	public class Mon_boss_Escarot_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Zawra_Skill_1)]
	public class Mon_pc_summon_boss_Zawra_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Silva_griffin_Skill_1)]
	public class Mon_pc_summon_boss_Silva_griffin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 55f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_castle_princess_Skill_1)]
	public class Mon_pc_summon_boss_castle_princess_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 7f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_hauberk_Skill_1, SkillId.Mon_boss_FD_Riteris_Skill_1)]
	public class Mon_GFB_boss_hauberk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_hauberk_Skill_3)]
	public class Mon_GFB_boss_hauberk_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 150f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_kurmis_Skill_1)]
	public class Mon_GFB_boss_kurmis_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_Naktis_Skill_1)]
	public class Mon_GFB_boss_Naktis_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_Gosal_Skill_1)]
	public class Mon_GFB_boss_Gosal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 8)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_GFB_boss_bebraspion_Skill_2)]
	public class Mon_GFB_boss_bebraspion_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_bebraspion_Skill_3)]
	public class Mon_GFB_boss_bebraspion_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2450);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 65f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Rambandgad_red_Skill_3)]
	public class Mon_boss_Rambandgad_red_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 180f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_Rambandgad_red_Skill_5)]
	public class Mon_boss_Rambandgad_red_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_Fireload_Skill_3)]
	public class Mon_GFB_boss_Fireload_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 12)
				target.StartBuff(BuffId.UC_flame, 1, 0, TimeSpan.FromMilliseconds(15000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Kandlogre_Skill_1)]
	public class Mon_boss_Kandlogre_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Velnipper_Skill_1)]
	public class Mon_boss_Velnipper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 110f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 40f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 4)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(15000), caster, skill.Id);
			if (RandomProvider.Get().Next(100) < 3)
				target.StartBuff(BuffId.UC_poison, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Porahound_Skill_1)]
	public class Mon_boss_Porahound_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Porahound_Skill_2)]
	public class Mon_boss_Porahound_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_jezebel_Skill_1)]
	public class Mon_boss_jezebel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 40f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 4)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(15000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_jezebel_Skill_4)]
	public class Mon_boss_jezebel_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_Velschariot_Skill_1)]
	public class Mon_boss_Velschariot_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 80)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Pbeta_Skill_1)]
	public class Mon_boss_Pbeta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_kabad_Skill_1)]
	public class Mon_boss_kabad_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_ignas_Skill_1)]
	public class Mon_boss_ignas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Raid_boss_blackGargoyle_Skill_1, SkillId.Mon_FD_boss_Velcoffer_Skill_1)]
	public class Mon_Raid_boss_blackGargoyle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Raid_boss_blackGargoyle_Skill_4)]
	public class Mon_Raid_boss_blackGargoyle_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Monster_Slow, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Raid_boss_blackGargoyle_Skill_5)]
	public class Mon_Raid_boss_blackGargoyle_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(5800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(5600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 1000f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Mon_raid_stun, 3, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_flowertree_Skill_1)]
	public class Mon_boss_flowertree_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_kinghammer_Skill_1)]
	public class Mon_boss_kinghammer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Wyvern_Skill_4)]
	public class Mon_boss_Wyvern_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1450);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Raid_boss_blackGargoyle_Skill_7)]
	public class Mon_Raid_boss_blackGargoyle_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_boss_flowertree_Skill_5)]
	public class Mon_boss_flowertree_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_banshee_Skill_1)]
	public class Mon_boss_banshee_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Gagoyle_purple_Skill_1)]
	public class Mon_Gagoyle_purple_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Gagoyle_purple_Skill_8)]
	public class Mon_Gagoyle_purple_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_mspblood, 1, 1000, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_minivern_raid_Skill_2)]
	public class Mon_minivern_raid_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_monster_blackGargoyle_mini_Skill_1)]
	public class Mon_monster_blackGargoyle_mini_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_monster_blackGargoyle_mini_Skill_2)]
	public class Mon_monster_blackGargoyle_mini_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Mon_Def_down, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_solcomm_Skill_1, SkillId.Mon_boss_solcomm_Q2_Skill_1)]
	public class Mon_boss_solcomm_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_solcomm_Skill_4)]
	public class Mon_boss_solcomm_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_F_boss_succubus_Skill_1, SkillId.Mon_pc_summon_boss_succubus_Skill_1)]
	public class Mon_F_boss_succubus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 75f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_F_boss_succubus_Skill_3)]
	public class Mon_F_boss_succubus_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Glackuman_Skill_7)]
	public class Mon_F_boss_Glackuman_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_armorbreak, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_F_boss_molich_Skill_1)]
	public class Mon_F_boss_molich_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1150);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_F_boss_FerretMarauder_Skill_7)]
	public class Mon_F_boss_FerretMarauder_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10991);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10791);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Kerberos_Skill_1)]
	public class Mon_F_boss_Kerberos_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Kerberos_Skill_5)]
	public class Mon_F_boss_Kerberos_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_Quipmage_Skill_1)]
	public class Mon_boss_Quipmage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_succubus_Skill_2)]
	public class Mon_pc_summon_boss_succubus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 45f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_slowdown, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ID_kucarry_symbani_Skill_1)]
	public class Mon_ID_kucarry_symbani_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 2)
				target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(4000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ID_umbra_warrior_Skill_2)]
	public class Mon_ID_umbra_warrior_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 2)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_KindronWielder_Skill_1)]
	public class Mon_KindronWielder_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_afisher_Skill_1)]
	public class Mon_afisher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 16f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_gob_Skill_1)]
	public class Mon_gob_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 17.5f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_gob_Skill_2)]
	public class Mon_gob_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 17.5f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_VarleFloater_Skill_1)]
	public class Mon_VarleFloater_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_NimrahLancer_Skill_1)]
	public class Mon_NimrahLancer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_Nimrahsoldier_Skill_1)]
	public class Mon_Nimrahsoldier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_VarleGunner_Skill_1)]
	public class Mon_VarleGunner_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 140f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_VarleHench_Skill_1, SkillId.Mon_Monitor_lizard_Skill_1)]
	public class Mon_VarleHench_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_VarleSkipper_Skill_1)]
	public class Mon_VarleSkipper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_VarleHenchman_Skill_1)]
	public class Mon_VarleHenchman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_VarleAnchor_Skill_1)]
	public class Mon_VarleAnchor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_VarleHelmsman_Skill_1)]
	public class Mon_VarleHelmsman_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_KindronLilter_Skill_1)]
	public class Mon_KindronLilter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_ravisher_Skill_1)]
	public class Mon_ravisher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_lakegolem_Skill_1)]
	public class Mon_lakegolem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_pondus_Skill_1)]
	public class Mon_pondus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_lily_belly_Skill_1)]
	public class Mon_lily_belly_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_jelly_belly_Skill_1)]
	public class Mon_jelly_belly_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_atti_Skill_1, SkillId.Mon_richring_Skill_1)]
	public class Mon_atti_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 17f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_richring_Skill_2)]
	public class Mon_richring_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1075);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(875);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_yakyak_Skill_1)]
	public class Mon_yakyak_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 33f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_yakyak_Skill_2)]
	public class Mon_yakyak_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 17f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_yak_magician_Skill_1)]
	public class Mon_yak_magician_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_yak_druid_Skill_1)]
	public class Mon_yak_druid_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_anchor_golem_Skill_2)]
	public class Mon_anchor_golem_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(580);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(380);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_blossom_beetle_Skill_1)]
	public class Mon_blossom_beetle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_blossom_beetle_Skill_2)]
	public class Mon_blossom_beetle_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_bush_beetle_Skill_2)]
	public class Mon_bush_beetle_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 17.5f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_yakmambo_Skill_1)]
	public class Mon_yakmambo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_yakmab_Skill_1)]
	public class Mon_yakmab_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_yakmab_Skill_2)]
	public class Mon_yakmab_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_nook_Skill_1)]
	public class Mon_nook_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_nook_Skill_2)]
	public class Mon_nook_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boor_Skill_1)]
	public class Mon_boor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_mangosting_Skill_1)]
	public class Mon_mangosting_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mangosting_Skill_2)]
	public class Mon_mangosting_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 28f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_half_mangosting_Skill_2)]
	public class Mon_half_mangosting_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 28f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_half_mangosting_Skill_3)]
	public class Mon_half_mangosting_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_drooper_Skill_1)]
	public class Mon_drooper_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(675);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(475);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_drooper_Skill_3)]
	public class Mon_drooper_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_oscuro_Skill_1)]
	public class Mon_oscuro_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 22f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_oscuro_Skill_2)]
	public class Mon_oscuro_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_claro_Skill_1)]
	public class Mon_claro_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 22f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_page_mimic_Skill_1)]
	public class Mon_page_mimic_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_aclis_angel_Skill_1, SkillId.Mon_Humming_duke_Skill_1)]
	public class Mon_aclis_angel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_levada_Skill_1)]
	public class Mon_levada_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_marte_book_Skill_1)]
	public class Mon_marte_book_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_crobasia_Skill_1, SkillId.Mon_ep16_2_crobasia_Skill_1)]
	public class Mon_crobasia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_rotacion_Skill_1)]
	public class Mon_rotacion_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boogie_box_Skill_1, SkillId.Mon_ep16_2_boogie_box_Skill_1)]
	public class Mon_boogie_box_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_cretobiang_Skill_1)]
	public class Mon_cretobiang_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_creto_Skill_1, SkillId.Mon_ep16_2_creto_Skill_1)]
	public class Mon_creto_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_lapinel_Skill_1, SkillId.Mon_weekly_lapinel_lucy_summon_Skill_1, SkillId.Mon_ep16_2_lapinel_Skill_1)]
	public class Mon_lapinel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_NimrahDuke_Skill_1)]
	public class Mon_NimrahDuke_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_NimrahDuke_Skill_2)]
	public class Mon_NimrahDuke_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_NimrahPricker_Skill_1)]
	public class Mon_NimrahPricker_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_hauberk_Q1_Skill_1)]
	public class Mon_boss_hauberk_Q1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_solcomm_Q2_Skill_4)]
	public class Mon_boss_solcomm_Q2_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_solcomm_Q2_Skill_6)]
	public class Mon_boss_solcomm_Q2_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_lucy_Skill_1)]
	public class Mon_boss_lucy_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_event_big_onion_Halloween_Skill_1)]
	public class Mon_event_big_onion_Halloween_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_event_Spector_Halloween_Skill_1)]
	public class Mon_event_Spector_Halloween_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_event_Spector_Halloween_Skill_2)]
	public class Mon_event_Spector_Halloween_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_event_Spector_Halloween_Skill_3, SkillId.Mon_d_uniq_boss_valdovas_Skill_8)]
	public class Mon_event_Spector_Halloween_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_Riteris_Skill_1)]
	public class Mon_GFB_boss_Riteris_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_PantoRex_Skill_5)]
	public class Mon_GFB_boss_PantoRex_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 70f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_PantoRex_Skill_6)]
	public class Mon_GFB_boss_PantoRex_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1250);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 220f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GFB_boss_PantoRex_Skill_9)]
	public class Mon_GFB_boss_PantoRex_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(870);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(670);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 220f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_Panto_Gwand_Skill_3)]
	public class Mon_GM_Panto_Gwand_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Raid_boss_Gremlin_minimal_Skill_1)]
	public class Mon_Raid_boss_Gremlin_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_d_raid_boss_RytaSwort_minimal_Skill_2)]
	public class Mon_d_raid_boss_RytaSwort_minimal_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Raid_boss_blackGargoyle_Skill_13)]
	public class Mon_Raid_boss_blackGargoyle_Skill_13 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_GM_Large_crossbow_Skill_1)]
	public class Mon_GM_Large_crossbow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_GM_arrow_trap_Skill_1)]
	public class Mon_GM_arrow_trap_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Lapflammer_uphill_Skill_1)]
	public class Mon_Lapflammer_uphill_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_piedpiper_mouse_Skill_1, SkillId.Mon_piedpiper_mouse_White_Skill_1)]
	public class Mon_piedpiper_mouse_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.HamelnNagetier_Debuff, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_pate_Skill_1)]
	public class Mon_pate_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_pate_Skill_2)]
	public class Mon_pate_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_coterie_Skill_1, SkillId.Mon_wajak_walker_Skill_1)]
	public class Mon_coterie_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Spinacho_Skill_1, SkillId.Mon_ep12_Nuka_shield_Skill_2, SkillId.Mon_ep14_1_Bleakferret_Spear_Skill_1)]
	public class Mon_Spinacho_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Spinacho_Skill_2)]
	public class Mon_Spinacho_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_Rubeta_Skill_1)]
	public class Mon_Rubeta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Little_rubeta_Skill_2)]
	public class Mon_Little_rubeta_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mutt_Skill_1)]
	public class Mon_Mutt_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Mutt_Skill_2)]
	public class Mon_Mutt_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_naste_Skill_1)]
	public class Mon_naste_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_rabbler_Skill_2)]
	public class Mon_rabbler_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_wryer_Skill_1)]
	public class Mon_wryer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_nasleia_Skill_1)]
	public class Mon_nasleia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_nasleia_Skill_2)]
	public class Mon_nasleia_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Madlens_Skill_1)]
	public class Mon_Madlens_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Grob_Skill_2, SkillId.Mon_ep12_Living_armor_Skill_2)]
	public class Mon_Grob_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_hafter_Skill_1)]
	public class Mon_hafter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Waglog_Skill_1)]
	public class Mon_Waglog_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_gleamlens_Skill_1)]
	public class Mon_gleamlens_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_bishopstar_Skill_1)]
	public class Mon_bishopstar_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_wajak_walker_Skill_2)]
	public class Mon_wajak_walker_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_bishop_point_Skill_1, SkillId.Mon_NightPanto_Archer_Skill_1)]
	public class Mon_bishop_point_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Kigle_Skill_1)]
	public class Mon_Kigle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Kigle_Skill_2)]
	public class Mon_Kigle_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_poncer_Skill_2)]
	public class Mon_poncer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 25f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Moltooth_Skill_1)]
	public class Mon_Moltooth_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Moltooth_Skill_2)]
	public class Mon_Moltooth_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_beissen_Skill_1, SkillId.Mon_beissen_Skill_2)]
	public class Mon_beissen_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_punter_Skill_1, SkillId.Mon_ignas_summon_punter_Skill_1)]
	public class Mon_punter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_glovegolem_Skill_1)]
	public class Mon_glovegolem_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_kiglelops_Skill_1)]
	public class Mon_kiglelops_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_bishop_hart_Skill_1)]
	public class Mon_bishop_hart_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Yishontorcher_Skill_1)]
	public class Mon_Yishontorcher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Yishontorcher_Skill_2)]
	public class Mon_Yishontorcher_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_KindronLeader_Skill_1)]
	public class Mon_KindronLeader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_KindronLeader_Skill_2)]
	public class Mon_KindronLeader_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 30)
				target.StartBuff(BuffId.UC_stun, 1, 0, TimeSpan.FromMilliseconds(2000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_KindronBoor_Skill_2)]
	public class Mon_KindronBoor_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Humming_duke_Skill_2)]
	public class Mon_Humming_duke_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 50)
				target.StartBuff(BuffId.Poison_Mon, 10, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_NightPanto_mage_Skill_1)]
	public class Mon_NightPanto_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_vespera_Skill_1)]
	public class Mon_vespera_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_beetle_green_Skill_1, SkillId.Mon_Tripy_Skill_1)]
	public class Mon_beetle_green_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_beetle_green_Skill_2)]
	public class Mon_beetle_green_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_NightPanto_Stellar_Skill_1)]
	public class Mon_NightPanto_Stellar_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_NightPanto_Archer_Skill_2)]
	public class Mon_NightPanto_Archer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_nastudeu_Skill_1, SkillId.Mon_PuppetM_Skill_1)]
	public class Mon_nastudeu_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mushuta_Skill_1)]
	public class Mon_Mushuta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 85f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Vine_Walker_Skill_1)]
	public class Mon_Vine_Walker_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Wiza_moya_Skill_1)]
	public class Mon_Wiza_moya_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mimorat_pink_Skill_1)]
	public class Mon_Mimorat_pink_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_Mimorat_pink_Skill_2)]
	public class Mon_Mimorat_pink_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Mimorat_green_Skill_1)]
	public class Mon_Mimorat_green_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Haunted_house_Skill_1)]
	public class Mon_Haunted_house_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_slime_wizard_Skill_1)]
	public class Mon_slime_wizard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_slime_wizard_Skill_2)]
	public class Mon_slime_wizard_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_popup_cat_Skill_1, SkillId.Mon_ep12_aklaspetal_sword_Skill_1)]
	public class Mon_popup_cat_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_PervadingQueen_Skill_3, SkillId.Mon_Greedyprisoner_Skill_2)]
	public class Mon_boss_PervadingQueen_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Boss_TealSpecter_Skill_1)]
	public class Mon_Boss_TealSpecter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_uniq_id_boss_Asiomage_Skill_1, SkillId.Mon_FD_boss_Asiomage_Skill_1)]
	public class Mon_uniq_id_boss_Asiomage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_npc_schaffenstar_executive_Skill_1)]
	public class Mon_npc_schaffenstar_executive_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_npc_schaffenstar_member_Skill_1)]
	public class Mon_npc_schaffenstar_member_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_uniq_boss_Mandara_Skill_1)]
	public class Mon_uniq_boss_Mandara_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 65f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_boss_Wastrel_Skill_1, SkillId.Mon_FD_boss_Wastrel_Skill_1)]
	public class Mon_boss_Wastrel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_Wastrel_Skill_6, SkillId.Mon_boss_Skiaclipse_Skill_7, SkillId.Mon_Legend_Boss_Skiaclipse_Skill_7, SkillId.Mon_Legend_Boss_Skiaclipse_Solo_Skill_7, SkillId.Mon_boss_Skiaclipse_Solo_Skill_7, SkillId.Mon_F_boss_Skiaclipse_Skill_7, SkillId.Mon_FD_boss_Wastrel_Skill_4)]
	public class Mon_boss_Wastrel_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_KindronShooter_Skill_1)]
	public class Mon_KindronShooter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_KindronShooter_Skill_2)]
	public class Mon_KindronShooter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Colony_Ballista_Skill_1)]
	public class Mon_Colony_Ballista_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.GuildColony_Ballista_Stun_DeBuff, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Colony_Ballista_Skill_2)]
	public class Mon_Colony_Ballista_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_AmissDog_Skill_1)]
	public class Mon_boss_AmissDog_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_AmissDog_Skill_2)]
	public class Mon_boss_AmissDog_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_LungerBoar_Skill_1)]
	public class Mon_boss_LungerBoar_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_deprotect, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_LungerBoar_Skill_2)]
	public class Mon_boss_LungerBoar_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2400);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_stun, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Meskalord_Skill_1)]
	public class Mon_boss_Meskalord_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1250);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1050);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 55f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(1000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Meskalord_Skill_4)]
	public class Mon_boss_Meskalord_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_madon_maiden_Skill_1)]
	public class Mon_boss_madon_maiden_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_uniq_id_boss_ignas_Skill_1)]
	public class Mon_uniq_id_boss_ignas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 30)
				target.StartBuff(BuffId.UniqRaid_Ignas_Phase2_Buff, 1, 0, TimeSpan.FromMilliseconds(60000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_uniq_id_boss_ignas_Skill_3)]
	public class Mon_uniq_id_boss_ignas_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 20)
				target.StartBuff(BuffId.UniqRaid_Ignas_Phase2_Buff, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_uniq_id_boss_ProddedHorse_Skill_4)]
	public class Mon_uniq_id_boss_ProddedHorse_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(4000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_fear, 1, 0, TimeSpan.FromMilliseconds(2000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_pcskill_skullwizard_Skill_1)]
	public class Mon_pcskill_skullwizard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Raid_boss_Boruta_Skill_1)]
	public class Mon_Raid_boss_Boruta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 115f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_uniq_id_boss_ignas_Skill_8)]
	public class Mon_uniq_id_boss_ignas_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_pc_summon_boss_Ignas_Skill_1)]
	public class Mon_pc_summon_boss_Ignas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Raid_boss_Boruta_Skill_4, SkillId.Mon_boss_Boruta_Guild_Skill_1)]
	public class Mon_Raid_boss_Boruta_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 180f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_infro_Crabil_Skill_2, SkillId.Mon_tooter_Skill_2)]
	public class Mon_infro_Crabil_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_amphibigola_Skill_1)]
	public class Mon_amphibigola_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_amphibigola_Skill_2)]
	public class Mon_amphibigola_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Frocoli_Skill_1)]
	public class Mon_Frocoli_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Frocoli_Skill_2)]
	public class Mon_Frocoli_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Spider_Skill_1)]
	public class Mon_Spider_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_tooter_Skill_1)]
	public class Mon_tooter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 25f;
	}

	[SkillHandler(SkillId.Mon_uniq_id_boss_Moringponia_Skill_1)]
	public class Mon_uniq_id_boss_Moringponia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_gazer_Skill_1, SkillId.Mon_event_gazer_Skill_1)]
	public class Mon_gazer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_gazer_Skill_2)]
	public class Mon_gazer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Greedyprisoner_Skill_1)]
	public class Mon_Greedyprisoner_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Maskexecutor_Skill_1)]
	public class Mon_Maskexecutor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_Maskexecutor_Skill_2)]
	public class Mon_Maskexecutor_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_uniq_id_boss_Tantaliser_Skill_1, SkillId.Mon_boss_Tantaliser_Skill_1)]
	public class Mon_uniq_id_boss_Tantaliser_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_AR_boss_BiteRegina_Skill_1)]
	public class Mon_AR_boss_BiteRegina_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_AR_boss_BiteRegina_Skill_3)]
	public class Mon_AR_boss_BiteRegina_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_AR_boss_molich_Skill_1)]
	public class Mon_AR_boss_molich_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Amacalf_Skill_1)]
	public class Mon_Amacalf_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Amacalf_Skill_2)]
	public class Mon_Amacalf_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Rudas_elavine_Skill_1)]
	public class Mon_Rudas_elavine_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Rudas_elavine_Skill_2)]
	public class Mon_Rudas_elavine_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_velsoarer_Skill_2)]
	public class Mon_velsoarer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_cloverin_Skill_2)]
	public class Mon_cloverin_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_Rafflet_Skill_1)]
	public class Mon_Rafflet_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_gigglecat_Skill_1)]
	public class Mon_gigglecat_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_infrogremlin_Skill_1)]
	public class Mon_infrogremlin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_infrogremlin_Skill_2)]
	public class Mon_infrogremlin_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_delione_Skill_2)]
	public class Mon_delione_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_fragolin_Skill_2)]
	public class Mon_fragolin_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_chesha_venom_Skill_1)]
	public class Mon_chesha_venom_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ghosbebe_Skill_1)]
	public class Mon_ghosbebe_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_ghoscat_Skill_1)]
	public class Mon_ghoscat_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_gland_Skill_1)]
	public class Mon_gland_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_gland_Skill_2)]
	public class Mon_gland_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_grievous_wheel_Skill_1)]
	public class Mon_grievous_wheel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_grievous_wheel_Skill_2)]
	public class Mon_grievous_wheel_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_banterer_Skill_1, SkillId.Mon_ep16_1_gravegolem_Skill_1)]
	public class Mon_banterer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ArchGargoyle_Skill_1)]
	public class Mon_ArchGargoyle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_hooter_Skill_1)]
	public class Mon_hooter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ShillEclipse_Skill_1)]
	public class Mon_ShillEclipse_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ShillEclipse_Skill_3)]
	public class Mon_ShillEclipse_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.Zero;
		protected override TimeSpan HitDelay { get; } = TimeSpan.Zero;
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_Monitor_lizard_Skill_2)]
	public class Mon_Monitor_lizard_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 22f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_chesha_needle_Skill_1)]
	public class Mon_chesha_needle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_chesha_needle_Skill_2)]
	public class Mon_chesha_needle_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ghosnatus_Skill_1, SkillId.Mon_ep14_1_Bleakferret_Gladiator_Skill_1)]
	public class Mon_ghosnatus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ghosnatus_Skill_2)]
	public class Mon_ghosnatus_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 70f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Skiaclipse_Sealed_Nocage_Skill_2)]
	public class Mon_Legend_Boss_Skiaclipse_Sealed_Nocage_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10119);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9919);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Moringponia_Skill_1, SkillId.Mon_Uniq_Boss_Moringponia_Skill_1)]
	public class Mon_F_boss_Moringponia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_F_boss_Moringponia_Skill_8)]
	public class Mon_F_boss_Moringponia_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Moringponia_Skill_1, SkillId.Mon_Legend_Boss_Moringponia_Hard_Skill_1, SkillId.Mon_Legend_Boss_Moringponia_Hard_Solo_Skill_1, SkillId.Mon_FD_boss_Moringponia_Skill_1)]
	public class Mon_Legend_Boss_Moringponia_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_Uniq_Boss_Tantaliser_Skill_1)]
	public class Mon_Uniq_Boss_Tantaliser_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_Uniq_Boss_Tantaliser_Skill_5, SkillId.Mon_FD_boss_Tantaliser_Skill_5)]
	public class Mon_Uniq_Boss_Tantaliser_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Tantaliser_Skill_1, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_1, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_1, SkillId.Mon_FD_boss_Tantaliser_Skill_1)]
	public class Mon_Legend_Boss_Tantaliser_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 130f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Tantaliser_Skill_5, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_5, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_5)]
	public class Mon_Legend_Boss_Tantaliser_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Tantaliser_Skill_11, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_11, SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_11)]
	public class Mon_Legend_Boss_Tantaliser_Skill_11 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep12_aklaspetal_sword_Skill_2)]
	public class Mon_ep12_aklaspetal_sword_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep12_Orc_leader_Skill_1)]
	public class Mon_ep12_Orc_leader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(850);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_ep12_Living_armor_Skill_1)]
	public class Mon_ep12_Living_armor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_Nuka_shield_Skill_1)]
	public class Mon_ep12_Nuka_shield_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_uniq_mushroom_ent_black_Skill_1)]
	public class Mon_uniq_mushroom_ent_black_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.MORINGPONIA_POISON, 1, 0, TimeSpan.FromMilliseconds(60000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_uniq_mushroom_ent_black_Skill_3)]
	public class Mon_uniq_mushroom_ent_black_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.MORINGPONIA_POISON, 1, 0, TimeSpan.FromMilliseconds(60000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Legend_mushroom_ent_black_Skill_1)]
	public class Mon_Legend_mushroom_ent_black_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_mushroom_ent_black_Skill_3)]
	public class Mon_Legend_mushroom_ent_black_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_moringaga_Skill_1, SkillId.Mon_Legend_moringaga_Skill_2, SkillId.Mon_Legend_moringaga_Hard_Skill_2)]
	public class Mon_Legend_moringaga_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_Zawra_Skill_1, SkillId.Mon_field_boss_Zawra_Skill_1)]
	public class Mon_weekly_boss_Zawra_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_ep12_castle_troll_Skill_1)]
	public class Mon_ep12_castle_troll_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_castle_troll_Skill_2)]
	public class Mon_ep12_castle_troll_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep12_castle_goblin_archer_Skill_1)]
	public class Mon_ep12_castle_goblin_archer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_Orc_glaive_Skill_1)]
	public class Mon_ep12_Orc_glaive_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_Orc_wand_Skill_1)]
	public class Mon_ep12_Orc_wand_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 110f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_Wolf_leader_Skill_1)]
	public class Mon_ep12_Wolf_leader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_Wolf_leader_Skill_2)]
	public class Mon_ep12_Wolf_leader_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep12_Wolf_Skill_2)]
	public class Mon_ep12_Wolf_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep12_Neckko_Skill_2)]
	public class Mon_ep12_Neckko_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_Poevita_Skill_1)]
	public class Mon_ep12_Poevita_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep12_Poevita_Skill_2)]
	public class Mon_ep12_Poevita_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep12_Sodininkas_Skill_2)]
	public class Mon_ep12_Sodininkas_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_ep12_Zima_Skill_2)]
	public class Mon_ep12_Zima_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep12_Goblin_sword_rider_Skill_1)]
	public class Mon_ep12_Goblin_sword_rider_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(250);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;
	}

	[SkillHandler(SkillId.Mon_ep12_Castle_beetle_Skill_1)]
	public class Mon_ep12_Castle_beetle_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_weekly_pattern_Skill_5)]
	public class Mon_weekly_pattern_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_FireWall_Buff, 1, 0, TimeSpan.FromMilliseconds(70000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_pattern_Skill_6)]
	public class Mon_weekly_pattern_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_Explosion_Debuff, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_pattern_Skill_8)]
	public class Mon_weekly_pattern_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_pattern_Skill_11)]
	public class Mon_weekly_pattern_Skill_11 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_RuneOfDeath_Debuff, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_pattern_Skill_12, SkillId.Mon_mythic_pattern_Skill_4)]
	public class Mon_weekly_pattern_Skill_12 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_RuneOfSummon_Debuff, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_pattern_Skill_13, SkillId.Mon_mythic_pattern_Skill_5)]
	public class Mon_weekly_pattern_Skill_13 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_Overload_Debuff, 1, 0, TimeSpan.FromMilliseconds(60000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_boss_hauberk_Skill_1, SkillId.Mon_field_boss_hauberk_Skill_1)]
	public class Mon_weekly_boss_hauberk_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_helgasercle_Skill_2, SkillId.Mon_field_boss_helgasercle_Skill_2)]
	public class Mon_weekly_boss_helgasercle_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_bleed, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
			target.StartBuff(BuffId.Weekly_Helgasercle_Debuff, 1, 0, TimeSpan.FromMilliseconds(12000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_boss_lecifer_Skill_1, SkillId.Mon_field_boss_lecifer_Skill_1)]
	public class Mon_weekly_boss_lecifer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_FieldRift_pattern_Skill_4)]
	public class Mon_FieldRift_pattern_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Uniq_boss_Pbeta_Skill_1, SkillId.Mon_Legend_boss_Pbeta_Skill_1, SkillId.Mon_Uniq_boss_Pbeta_Solo_Skill_1, SkillId.Mon_Legend_boss_Pbeta_Solo_Skill_1, SkillId.Mon_FD_boss_Pbeta_Skill_1)]
	public class Mon_Uniq_boss_Pbeta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Moringponia_Hard_Skill_8)]
	public class Mon_Legend_Boss_Moringponia_Hard_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Tantaliser_Hard_Skill_9)]
	public class Mon_Legend_Boss_Tantaliser_Hard_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Vasilissa_Skill_5)]
	public class Mon_boss_Vasilissa_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 350f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 67f;
	}

	[SkillHandler(SkillId.Mon_boss_Vasilissa_Skill_9, SkillId.Mon_boss_Vasilissa_Skill_21)]
	public class Mon_boss_Vasilissa_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Vasilissa_Skill_15)]
	public class Mon_boss_Vasilissa_Skill_15 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 400f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 67f;
	}

	[SkillHandler(SkillId.Mon_Legend_Hard_mushroom_ent_black_Skill_1)]
	public class Mon_Legend_Hard_mushroom_ent_black_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Hard_mushroom_ent_black_Skill_3)]
	public class Mon_Legend_Hard_mushroom_ent_black_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1350);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_ChiefGuard_Skill_8, SkillId.Mon_field_boss_ChiefGuard_Skill_8)]
	public class Mon_weekly_boss_ChiefGuard_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Irredians_TelHarsha_Skill_1)]
	public class Mon_boss_Irredians_TelHarsha_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_Irredians_TelHarsha_Skill_3, SkillId.Mon_boss_Irredians_TelHarsha_Skill_6, SkillId.Mon_boss_Irredians_TelHarsha_pattern_Skill_1, SkillId.Mon_boss_freedungeon_telharsha_Skill_6)]
	public class Mon_boss_Irredians_TelHarsha_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Irredians_TelHarsha_Skill_4)]
	public class Mon_boss_Irredians_TelHarsha_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 70f;
	}

	[SkillHandler(SkillId.Mon_boss_Irredians_TelHarsha_Skill_7, SkillId.Mon_boss_freedungeon_telharsha_Skill_7)]
	public class Mon_boss_Irredians_TelHarsha_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Blind, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Irredians_TelHarsha_Skill_11, SkillId.Mon_boss_freedungeon_telharsha_Skill_11)]
	public class Mon_boss_Irredians_TelHarsha_Skill_11 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_pcskill_skullelitesoldier_Skill_2)]
	public class Mon_pcskill_skullelitesoldier_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_solcomm_Skill_1, SkillId.Mon_field_boss_solcomm_Skill_1)]
	public class Mon_weekly_boss_solcomm_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_solcomm_Skill_3, SkillId.Mon_weekly_boss_solcomm_Skill_4, SkillId.Mon_weekly_boss_solcomm_Skill_5, SkillId.Mon_field_boss_solcomm_Skill_3, SkillId.Mon_field_boss_solcomm_Skill_4, SkillId.Mon_field_boss_solcomm_Skill_5)]
	public class Mon_weekly_boss_solcomm_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_Solcomm_Electric_Debuff, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_boss_solcomm_Skill_6, SkillId.Mon_field_boss_solcomm_Skill_6)]
	public class Mon_weekly_boss_solcomm_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_Solcomm_Electric_Debuff, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_boss_Tiny_mage_Skill_1)]
	public class Mon_weekly_boss_Tiny_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_Tiny_bow_Skill_1)]
	public class Mon_weekly_boss_Tiny_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 400f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_Tiny_bow_Skill_3)]
	public class Mon_weekly_boss_Tiny_bow_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 500f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Lv99_bound, 1, 0, TimeSpan.FromMilliseconds(2000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Moringponia_Hard_Solo_Skill_8)]
	public class Mon_Legend_Boss_Moringponia_Hard_Solo_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_9)]
	public class Mon_Legend_Boss_Tantaliser_Hard_Solo_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Uniq_boss_Glacier_Solo_Skill_6, SkillId.Mon_Legend_boss_Glacier_Solo_Skill_6)]
	public class Mon_Uniq_boss_Glacier_Solo_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_field_pattern_Skill_2)]
	public class Mon_field_pattern_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Field_FireWall_Buff, 1, 0, TimeSpan.FromMilliseconds(70000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_field_pattern_Skill_3)]
	public class Mon_field_pattern_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Field_Explosion_Debuff, 1, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_field_pattern_Skill_5, SkillId.Mon_mythic_pattern_Skill_3)]
	public class Mon_field_pattern_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_field_pattern_Skill_7)]
	public class Mon_field_pattern_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Field_RuneOfDeath_Debuff, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_field_pattern_Skill_8)]
	public class Mon_field_pattern_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Field_RuneOfSummon_Debuff, 1, 0, TimeSpan.FromMilliseconds(30000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_field_pattern_Skill_9)]
	public class Mon_field_pattern_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Field_Overload_Debuff, 1, 0, TimeSpan.FromMilliseconds(60000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Avataras_Skill_10)]
	public class Mon_Legend_Boss_Avataras_Skill_10 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 450f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 65f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Avataras_Guild_Skill_10, SkillId.Mon_Legend_Boss_Avataras_Auto_Skill_10)]
	public class Mon_Legend_Boss_Avataras_Guild_Skill_10 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 500f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 65f;
	}

	[SkillHandler(SkillId.Mon_ep12_raganosis_seeker_Skill_1)]
	public class Mon_ep12_raganosis_seeker_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep12_raganosis_ram_Skill_2)]
	public class Mon_ep12_raganosis_ram_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_RaganosisCommander_Skill_1)]
	public class Mon_boss_RaganosisCommander_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_1)]
	public class Mon_Legend_Boss_Giltine_Q1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_6)]
	public class Mon_Legend_Boss_Giltine_Q1_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Giltine_Q1_Skill_8)]
	public class Mon_Legend_Boss_Giltine_Q1_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.CriticalWound, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Giltine_Glackuman_minimal_Skill_1)]
	public class Mon_boss_Giltine_Glackuman_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_Giltine_Naktis_minimal_Skill_1)]
	public class Mon_boss_Giltine_Naktis_minimal_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_liepsna_spreader_Skill_1, SkillId.Mon_ep13_2_banshee_Skill_2)]
	public class Mon_ep13_liepsna_spreader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_liepsna_chaser_Skill_1)]
	public class Mon_ep13_liepsna_chaser_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep13_liepsna_destroyer_Skill_1)]
	public class Mon_ep13_liepsna_destroyer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_darbas_carrier_Skill_1)]
	public class Mon_ep13_darbas_carrier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep13_darbas_carrier_Skill_2)]
	public class Mon_ep13_darbas_carrier_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_darbas_loader_Skill_1, SkillId.Mon_ep13_biblioteka_keeper_Skill_1)]
	public class Mon_ep13_darbas_loader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_darbas_miner_Skill_1)]
	public class Mon_ep13_darbas_miner_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_vynmedis_Skill_1)]
	public class Mon_ep13_vynmedis_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_darbas_cleaner_Skill_1)]
	public class Mon_ep13_darbas_cleaner_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_elgesys_malkos_Skill_1)]
	public class Mon_ep13_elgesys_malkos_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_elgesys_collecter_Skill_1)]
	public class Mon_ep13_elgesys_collecter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_elgesys_collecter_Skill_2)]
	public class Mon_ep13_elgesys_collecter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_darbas_smuggler_Skill_1)]
	public class Mon_ep13_darbas_smuggler_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_elgesys_guard_Skill_1)]
	public class Mon_ep13_elgesys_guard_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_lapindal_ribbon_lucy_summon_Skill_1)]
	public class Mon_weekly_lapindal_ribbon_lucy_summon_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Weekly_boss_lucy_summon_Debuff, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_weekly_lapindal_ribbon_lucy_summon_Skill_2)]
	public class Mon_weekly_lapindal_ribbon_lucy_summon_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_pattern_Skill_2)]
	public class Mon_mythic_pattern_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Mythic_FireWall_Debuff, 1, 0, TimeSpan.FromMilliseconds(45000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_mythic_pattern_Skill_6)]
	public class Mon_mythic_pattern_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(9999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Legend_Boss_Avataras_Shadow_Skill_3)]
	public class Mon_Legend_Boss_Avataras_Shadow_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 450f;
		protected override float Width { get; } = 60f;
		protected override float Angle { get; } = 65f;
	}

	[SkillHandler(SkillId.Mon_boss_Genmagnus_pattern_Skill_1, SkillId.Mon_boss_Mythic_Genmagnus_Skill_2)]
	public class Mon_boss_Genmagnus_pattern_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 100f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Mythic_freeze, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_mythic_Fire_Dragon_purple_Skill_1)]
	public class Mon_mythic_Fire_Dragon_purple_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Hohen_ritter_Skill_2)]
	public class Mon_mythic_Hohen_ritter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_Hohen_mage_Skill_1)]
	public class Mon_mythic_Hohen_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 170f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_mythic_Elma_Skill_1)]
	public class Mon_mythic_Elma_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_Nuka_Skill_1, SkillId.Mon_mythic_Lapfighter_Skill_1)]
	public class Mon_mythic_Nuka_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Nuka_Skill_2)]
	public class Mon_mythic_Nuka_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_Nnuo_Skill_1)]
	public class Mon_mythic_Nnuo_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 65f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Nnuo_Skill_2)]
	public class Mon_mythic_Nnuo_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_mythic_Colifly_bow_Skill_1)]
	public class Mon_mythic_Colifly_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 160f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Banshee_pink_Skill_1)]
	public class Mon_mythic_Banshee_pink_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 20f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 10)
				target.StartBuff(BuffId.UC_freeze, 1, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_mythic_Banshee_pink_Skill_2)]
	public class Mon_mythic_Banshee_pink_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(950);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(750);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 55f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_mythic_Socket_bow_Skill_1)]
	public class Mon_mythic_Socket_bow_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 160f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_boss_Kerberos_Skill_1)]
	public class Mon_mythic_boss_Kerberos_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_mythic_boss_Kerberos_Skill_2)]
	public class Mon_mythic_boss_Kerberos_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_mythic_boss_Kerberos_Skill_6)]
	public class Mon_mythic_boss_Kerberos_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(3500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Mythic_Burn_Debuff, 1, 0, TimeSpan.FromMilliseconds(20000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_mythic_pawnd_Skill_1, SkillId.Mon_mythic_LapeArcher_Skill_1)]
	public class Mon_mythic_pawnd_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 170f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_mythic_Pawndel_Skill_1)]
	public class Mon_mythic_Pawndel_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_Glizardon_Skill_3)]
	public class Mon_mythic_Glizardon_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 70f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_NightMaiden_Skill_1)]
	public class Mon_mythic_NightMaiden_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 170f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			if (RandomProvider.Get().Next(100) < 5)
				target.StartBuff(BuffId.UC_blind, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_mythic_Hallowventor_Skill_1)]
	public class Mon_mythic_Hallowventor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Spector_Gh_Skill_1)]
	public class Mon_mythic_Spector_Gh_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_mythic_Spector_Gh_Skill_2)]
	public class Mon_mythic_Spector_Gh_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_minivern_Skill_1)]
	public class Mon_mythic_minivern_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Malstatue_Skill_1, SkillId.Mon_mythic_ticen_bow_Skill_1)]
	public class Mon_mythic_Malstatue_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 170f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Ultanun_Skill_1)]
	public class Mon_mythic_Ultanun_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 55f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_TerraNymph_mage_Skill_1, SkillId.Mon_mythic_Lapemiter_Skill_1)]
	public class Mon_mythic_TerraNymph_mage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 110f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_mythic_Chromadog_Skill_1)]
	public class Mon_mythic_Chromadog_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 13f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_Chromadog_Skill_2)]
	public class Mon_mythic_Chromadog_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_Lapfighter_Skill_2)]
	public class Mon_mythic_Lapfighter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 75f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_mythic_Velwriggler_Skill_1)]
	public class Mon_mythic_Velwriggler_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mythic_boss_Lapene_Skill_1)]
	public class Mon_mythic_boss_Lapene_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_durahan_Skill_1)]
	public class Mon_boss_FD_durahan_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_NetherBovine_Skill_1)]
	public class Mon_boss_FD_NetherBovine_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_Marionette_Skill_1)]
	public class Mon_boss_FD_Marionette_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_ginklas_Skill_1)]
	public class Mon_boss_FD_ginklas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_Deathweaver_Skill_1)]
	public class Mon_boss_FD_Deathweaver_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_Deathweaver_Skill_3)]
	public class Mon_boss_FD_Deathweaver_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(11199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_Deathweaver_Skill_4)]
	public class Mon_boss_FD_Deathweaver_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_SwordBallista_Skill_1)]
	public class Mon_boss_FD_SwordBallista_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_FD_SwordBallista_Skill_4)]
	public class Mon_boss_FD_SwordBallista_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_TH_raganosis_Phalanx_Skill_2)]
	public class Mon_TH_raganosis_Phalanx_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_FD_boss_ignas_Skill_1)]
	public class Mon_FD_boss_ignas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_FD_boss_Velcoffer_Skill_4)]
	public class Mon_FD_boss_Velcoffer_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2450);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 35f;
	}

	[SkillHandler(SkillId.Mon_FD_boss_Velcoffer_Skill_6)]
	public class Mon_FD_boss_Velcoffer_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_mokslas_researcher_Skill_1)]
	public class Mon_mokslas_researcher_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_mokslas_fumigation_Skill_1)]
	public class Mon_mokslas_fumigation_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 22f;
	}

	[SkillHandler(SkillId.Mon_mokslas_doctor_Skill_1)]
	public class Mon_mokslas_doctor_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 60f;
	}

	[SkillHandler(SkillId.Mon_ep13_2_wendigo_Skill_2)]
	public class Mon_ep13_2_wendigo_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_insane_marnoks_Skill_1)]
	public class Mon_boss_insane_marnoks_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_insane_marnoks_Skill_3)]
	public class Mon_boss_insane_marnoks_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(999999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(999799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Marnoks_poison_Debuff, 1, 0, TimeSpan.FromMilliseconds(15000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_insane_marnoks_Skill_4)]
	public class Mon_boss_insane_marnoks_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.Lv99_slowdown, 1, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_insane_marnoks_Skill_5)]
	public class Mon_boss_insane_marnoks_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep13_2_Goblin_sweeper_Skill_2)]
	public class Mon_ep13_2_Goblin_sweeper_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1E+08);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9.99998E+07);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_insane_marnoks_Skill_6)]
	public class Mon_boss_insane_marnoks_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(4000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(3700);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_2_Goblin_brandingiron_Skill_1)]
	public class Mon_ep13_2_Goblin_brandingiron_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep13_2_Goblin_brandingiron_Skill_2)]
	public class Mon_ep13_2_Goblin_brandingiron_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Vasilissa_Skill_19)]
	public class Mon_boss_Vasilissa_Skill_19 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 355f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Vasilissa_Skill_25)]
	public class Mon_boss_Vasilissa_Skill_25 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.VASILISSA_THUNDERSTROKE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(1000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_blackman_Skill_3)]
	public class Mon_boss_blackman_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_confuse, 1, 0, TimeSpan.FromMilliseconds(6000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Vibora_Spiritsoldier_Skill_1)]
	public class Mon_Vibora_Spiritsoldier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(150);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Vibora_Spiritsoldier_Skill_2)]
	public class Mon_Vibora_Spiritsoldier_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(375);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(175);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_Vibora_Spiritelitesoldier_Skill_2)]
	public class Mon_Vibora_Spiritelitesoldier_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(420);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(220);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 90f;
		protected override float Width { get; } = 90f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_Vibora_Spiritelitesoldier_Skill_3)]
	public class Mon_Vibora_Spiritelitesoldier_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99799);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_Asiomage_Skill_1)]
	public class Mon_weekly_boss_Asiomage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 80f;
		protected override float Angle { get; } = 55f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_Quipmage_Skill_1)]
	public class Mon_weekly_boss_Quipmage_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 45f;
		protected override float Angle { get; } = 55f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_diena_Skill_2, SkillId.Mon_field_boss_diena_Skill_2)]
	public class Mon_weekly_boss_diena_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Skill_1, SkillId.Mon_boss_RevivalPaulius_Skill_2, SkillId.Mon_boss_RevivalPaulius_Skill_8, SkillId.Mon_boss_RevivalPaulius_Skill_11, SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_1)]
	public class Mon_boss_RevivalPaulius_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Skill_4)]
	public class Mon_boss_RevivalPaulius_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_SKILL4_SLOWDOWN_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Skill_5)]
	public class Mon_boss_RevivalPaulius_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Skill_6)]
	public class Mon_boss_RevivalPaulius_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_LASER_HOLD_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_ep14_1_npc_pajauta_Skill_1)]
	public class Mon_ep14_1_npc_pajauta_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep14_1_npc_pajauta_Skill_2)]
	public class Mon_ep14_1_npc_pajauta_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_ep14_1_Bleakferret_Charger_Skill_1)]
	public class Mon_ep14_1_Bleakferret_Charger_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_ep14_1_Bleakferret_Gladiator_Skill_2)]
	public class Mon_ep14_1_Bleakferret_Gladiator_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_ep14_1_Bleakferret_shielder_Skill_1)]
	public class Mon_ep14_1_Bleakferret_shielder_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 25f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep14_1_GresmeBird_Skill_1)]
	public class Mon_ep14_1_GresmeBird_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 40f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_boss_DelmoreCastleGate_Skill_1)]
	public class Mon_boss_DelmoreCastleGate_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_DelmoreCastleGate_Skill_3)]
	public class Mon_boss_DelmoreCastleGate_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(90199);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_DelmoreCastleGate_Skill_4)]
	public class Mon_boss_DelmoreCastleGate_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(90199);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_DelmoreCastleGate_Skill_6)]
	public class Mon_boss_DelmoreCastleGate_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(90199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_DelmoreCastleGate_Skill_11, SkillId.Mon_boss_DelmoreCastleGate_Skill_12)]
	public class Mon_boss_DelmoreCastleGate_Skill_11 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Eyes_Skill_1)]
	public class Mon_boss_RevivalPaulius_Eyes_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_succubus_Skill_1, SkillId.Mon_field_boss_succubus_Skill_1)]
	public class Mon_weekly_boss_succubus_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_succubus_Skill_3, SkillId.Mon_field_boss_succubus_Skill_3)]
	public class Mon_weekly_boss_succubus_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_2, SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_8, SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_11)]
	public class Mon_boss_RevivalPaulius_Extreme_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_NORMAL_SKILL_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_4)]
	public class Mon_boss_RevivalPaulius_Extreme_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_SKILL4_SLOWDOWN_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
			target.StartBuff(BuffId.PAULIUS_NORMAL_SKILL_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_5)]
	public class Mon_boss_RevivalPaulius_Extreme_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_NORMAL_SKILL_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_6)]
	public class Mon_boss_RevivalPaulius_Extreme_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_LASER_HOLD_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
			target.StartBuff(BuffId.PAULIUS_NORMAL_SKILL_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_9, SkillId.Mon_boss_RevivalPaulius_Extreme_Skill_10)]
	public class Mon_boss_RevivalPaulius_Extreme_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_NORMAL_SKILL_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_1, SkillId.Mon_boss_Jellyzele_Skill_3, SkillId.Mon_boss_Jellyzele_Skill_14)]
	public class Mon_boss_Jellyzele_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_2)]
	public class Mon_boss_Jellyzele_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_5)]
	public class Mon_boss_Jellyzele_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
			target.StartBuff(BuffId.JELLYZELE_ELECTRIC_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_7)]
	public class Mon_boss_Jellyzele_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10699);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10499);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_ATK_REDUCE_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(10000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_15, SkillId.Mon_boss_Jellyzele_Skill_17, SkillId.Mon_boss_Jellyzele_Skill_28)]
	public class Mon_boss_Jellyzele_Skill_15 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_RESIDUAL_HEAT_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_16)]
	public class Mon_boss_Jellyzele_Skill_16 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_RESIDUAL_HEAT_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_19)]
	public class Mon_boss_Jellyzele_Skill_19 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_ELECTRIC_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
			target.StartBuff(BuffId.JELLYZELE_RESIDUAL_HEAT_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Jellyzele_Skill_21)]
	public class Mon_boss_Jellyzele_Skill_21 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10699);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10499);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_RESIDUAL_HEAT_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(3000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_Jellyzele_seaweed_Skill_1)]
	public class Mon_Jellyzele_seaweed_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(650);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(450);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_Jellyzele_seaweed_Skill_2)]
	public class Mon_Jellyzele_seaweed_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_ignas_Skill_1)]
	public class Mon_weekly_boss_ignas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_ignas_Skill_4)]
	public class Mon_weekly_boss_ignas_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 400f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_weekly_boss_ignas_Skill_5)]
	public class Mon_weekly_boss_ignas_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 200f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep14_2_Bleakferret_Lancer_Skill_1)]
	public class Mon_ep14_2_Bleakferret_Lancer_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_TransmutationSpreader_Q1_Skill_1)]
	public class Mon_boss_TransmutationSpreader_Q1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 100f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 55f;
	}

	[SkillHandler(SkillId.Mon_boss_Falouros_Skill_2, SkillId.Mon_boss_Falouros_Auto_Skill_2, SkillId.Mon_boss_Falouros_Solo_Skill_2)]
	public class Mon_boss_Falouros_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_BOUNCE_PAD_STUN_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(1000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Falouros_Skill_4, SkillId.Mon_boss_Falouros_Auto_Skill_4, SkillId.Mon_boss_Falouros_Solo_Skill_4)]
	public class Mon_boss_Falouros_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Falouros_Skill_5, SkillId.Mon_boss_Falouros_Auto_Skill_5, SkillId.Mon_boss_Falouros_Solo_Skill_5)]
	public class Mon_boss_Falouros_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.JELLYZELE_STICKY_SLOWDOWN_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Falouros_Skill_7, SkillId.Mon_boss_Falouros_Skill_12, SkillId.Mon_boss_Falouros_Auto_Skill_7, SkillId.Mon_boss_Falouros_Auto_Skill_12, SkillId.Mon_boss_Falouros_Solo_Skill_7, SkillId.Mon_boss_Falouros_Solo_Skill_12)]
	public class Mon_boss_Falouros_Skill_7 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Falouros_Skill_8, SkillId.Mon_boss_Falouros_Auto_Skill_8, SkillId.Mon_boss_Falouros_Solo_Skill_8)]
	public class Mon_boss_Falouros_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Falouros_Skill_9, SkillId.Mon_boss_Falouros_Auto_Skill_9, SkillId.Mon_boss_Falouros_Solo_Skill_9)]
	public class Mon_boss_Falouros_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_BOUNCE_PAD_STUN_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(2000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_npc_baubas2_Skill_1, SkillId.Mon_npc_baubas2_Skill_10, SkillId.Mon_dragoon_master_ex_Skill_1, SkillId.Mon_dragoon_master_ex_Skill_2, SkillId.Mon_dragoon_master_ex_Skill_3, SkillId.Mon_dragoon_master_ex_Skill_4, SkillId.Mon_boss_dragoon_ex_Skill_1, SkillId.Mon_boss_dragoon_ex_Skill_2, SkillId.Mon_boss_dragoon_ex_Skill_3, SkillId.Mon_boss_dragoon_ex_Skill_4, SkillId.Mon_boss_dragoon_ex_Skill_5, SkillId.Mon_boss_dragoon_ex_Skill_6, SkillId.Mon_boss_dragoon_ex_Skill_7, SkillId.Mon_boss_dragoon_ex_Skill_8, SkillId.Mon_boss_dragoon_ex_Skill_9, SkillId.Mon_boss_dragoon_ex_Skill_10)]
	public class Mon_npc_baubas2_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 110f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_npc_baubas2_Skill_4)]
	public class Mon_npc_baubas2_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_npc_baubas2_Skill_6)]
	public class Mon_npc_baubas2_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_npc_baubas2_Skill_8)]
	public class Mon_npc_baubas2_Skill_8 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 250f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_npc_baubas2_Skill_9)]
	public class Mon_npc_baubas2_Skill_9 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(99999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 350f;
		protected override float Width { get; } = 90f;
		protected override float Angle { get; } = 50f;
	}

	[SkillHandler(SkillId.Mon_boss_Roze_Skill_13, SkillId.Mon_boss_Roze_Auto_Skill_13, SkillId.Mon_boss_Roze_Solo_Skill_13, SkillId.Mon_boss_upinis_Skill_13, SkillId.Mon_boss_upinis_Auto_Skill_13, SkillId.Mon_boss_upinis_Solo_Skill_13)]
	public class Mon_boss_Roze_Skill_13 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Spreader_TransmutationSoldier_Skill_1)]
	public class Mon_boss_Spreader_TransmutationSoldier_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 70f;
		protected override float Width { get; } = 20f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_Pokubu_ferocious_Skill_1)]
	public class Mon_ep15_1_Pokubu_ferocious_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_Goblin_Elite_Skill_2)]
	public class Mon_ep15_1_Goblin_Elite_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_Goblin_Saman_Skill_2, SkillId.Mon_ep15_1_boss_Bubas_Skill_5)]
	public class Mon_ep15_1_Goblin_Saman_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_goblin_chaser_Skill_2)]
	public class Mon_ep15_1_goblin_chaser_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_goblin_fighter_Skill_1)]
	public class Mon_ep15_1_goblin_fighter_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_goblin_fighter_Skill_2)]
	public class Mon_ep15_1_goblin_fighter_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(550);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(350);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 65f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_boss_Bubas_Skill_1)]
	public class Mon_ep15_1_boss_Bubas_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_1_boss_Bubas_Skill_2)]
	public class Mon_ep15_1_boss_Bubas_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10191);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9991);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_freedungeon_telharsha_Skill_1)]
	public class Mon_boss_freedungeon_telharsha_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1900);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1700);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 45f;
	}

	[SkillHandler(SkillId.Mon_boss_freedungeon_telharsha_Skill_4)]
	public class Mon_boss_freedungeon_telharsha_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 70f;
	}

	[SkillHandler(SkillId.Mon_boss_Slogutis_Skill_11, SkillId.Mon_boss_Slogutis_Auto_Skill_11, SkillId.Mon_boss_Slogutis_Solo_Skill_11)]
	public class Mon_boss_Slogutis_Skill_11 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Slogutis_Skill_13, SkillId.Mon_boss_Slogutis_Auto_Skill_13, SkillId.Mon_boss_Slogutis_Solo_Skill_13)]
	public class Mon_boss_Slogutis_Skill_13 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Slogutis_Skill_14, SkillId.Mon_boss_Slogutis_Auto_Skill_14, SkillId.Mon_boss_Slogutis_Solo_Skill_14)]
	public class Mon_boss_Slogutis_Skill_14 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Slogutis_Skill_19, SkillId.Mon_boss_Slogutis_Auto_Skill_19, SkillId.Mon_boss_Slogutis_Solo_Skill_19)]
	public class Mon_boss_Slogutis_Skill_19 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_lapasape_mage_blue_Skill_2)]
	public class Mon_ep16_1_lapasape_mage_blue_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_sauga_Skill_2)]
	public class Mon_ep16_1_sauga_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 40f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_glyphring_Skill_2, SkillId.Mon_boss_merregina_despair_Q1_Skill_2, SkillId.Mon_boss_merregina_despair_Q1_Skill_5)]
	public class Mon_ep16_1_glyphring_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_tucen_Skill_2, SkillId.Mon_ep16_1_ticen_Skill_2)]
	public class Mon_ep16_1_tucen_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep16_1_gravegolem_Skill_2)]
	public class Mon_ep16_1_gravegolem_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 15f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_merregina_despair_Q1_Skill_1)]
	public class Mon_boss_merregina_despair_Q1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(700);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(500);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 80f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_merregina_despair_Q1_Skill_4)]
	public class Mon_boss_merregina_despair_Q1_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_boss_Grimreaper_Q2_Skill_3)]
	public class Mon_boss_Grimreaper_Q2_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1800);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 110f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_earring_revivalpaulius_Skill_3)]
	public class Mon_earring_revivalpaulius_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_SKILL4_SLOWDOWN_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_earring_revivalpaulius_Skill_4)]
	public class Mon_earring_revivalpaulius_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.PAULIUS_LASER_HOLD_DEBUFF, 99, 0, TimeSpan.FromMilliseconds(5000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_earring_jellyzele_Skill_1, SkillId.Mon_earring_jellyzele_Skill_6)]
	public class Mon_earring_jellyzele_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 40f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_earring_jellyzele_Skill_3, SkillId.Mon_earring_jellyzele_Skill_8)]
	public class Mon_earring_jellyzele_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10699);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10499);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_earring_slogutis_Skill_3)]
	public class Mon_earring_slogutis_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_earring_slogutis_Skill_4)]
	public class Mon_earring_slogutis_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_earring_slogutis_Skill_5)]
	public class Mon_earring_slogutis_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep16_2_rotacion_Skill_1)]
	public class Mon_ep16_2_rotacion_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1100);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(900);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 12f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep16_2_boss_rambandgad_Skill_3)]
	public class Mon_ep16_2_boss_rambandgad_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 10f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_ep16_2_boss_rambandgad_Skill_5)]
	public class Mon_ep16_2_boss_rambandgad_Skill_5 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1200);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 0f;
		protected override float Width { get; } = 100f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_crystal_golem_Skill_4, SkillId.Mon_boss_crystal_golem_Auto_Skill_4, SkillId.Mon_boss_crystal_golem_Solo_Skill_4, SkillId.Mon_boss_crystal_golem_season_Skill_4)]
	public class Mon_boss_crystal_golem_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1400);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 300f;
		protected override float Width { get; } = 50f;
		protected override float Angle { get; } = 0f;
	}

	[SkillHandler(SkillId.Mon_boss_crystal_golem_Skill_6, SkillId.Mon_boss_crystal_golem_Auto_Skill_6, SkillId.Mon_boss_crystal_golem_Solo_Skill_6, SkillId.Mon_boss_crystal_golem_season_Skill_6)]
	public class Mon_boss_crystal_golem_Skill_6 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 30f;

		protected override void OnHit(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult hitResult)
		{
			target.StartBuff(BuffId.UC_stun, 99, 0, TimeSpan.FromMilliseconds(2000), caster, skill.Id);
		}
	}

	[SkillHandler(SkillId.Mon_boss_Redania_Skill_1, SkillId.Mon_boss_Redania_Auto_Skill_1, SkillId.Mon_boss_Redania_Solo_Skill_1, SkillId.Mon_boss_Redania_Illusion_Skill_1)]
	public class Mon_boss_Redania_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 150f;
		protected override float Width { get; } = 200f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_boss_Redania_Skill_3, SkillId.Mon_boss_Redania_Skill_5, SkillId.Mon_boss_Redania_Skill_12, SkillId.Mon_boss_Redania_Skill_13, SkillId.Mon_boss_Redania_Auto_Skill_3, SkillId.Mon_boss_Redania_Auto_Skill_5, SkillId.Mon_boss_Redania_Auto_Skill_12, SkillId.Mon_boss_Redania_Auto_Skill_13, SkillId.Mon_boss_Redania_Solo_Skill_3, SkillId.Mon_boss_Redania_Solo_Skill_5, SkillId.Mon_boss_Redania_Solo_Skill_12, SkillId.Mon_boss_Redania_Solo_Skill_13, SkillId.Mon_boss_Redania_Illusion_Skill_3, SkillId.Mon_boss_Redania_Illusion_Skill_5, SkillId.Mon_boss_Redania_Illusion_Skill_12, SkillId.Mon_boss_Redania_Illusion_Skill_13)]
	public class Mon_boss_Redania_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10499);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(10299);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Redania_Scout_Skill_1, SkillId.Mon_boss_Redania_Hiveguard_Skill_1)]
	public class Mon_boss_Redania_Scout_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 50f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Laimara_Skill_3, SkillId.Mon_boss_Laimara_Auto_Skill_3, SkillId.Mon_boss_Veliora_Auto_Skill_3)]
	public class Mon_boss_Laimara_Skill_3 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(2800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(2600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 160f;
		protected override float Width { get; } = 200f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Zmei_Skill_1, SkillId.Mon_boss_Zmei_Skill_2, SkillId.Mon_boss_Zmei_Auto_Skill_1, SkillId.Mon_boss_Zmei_Auto_Skill_2, SkillId.Mon_boss_Zmei_Solo_Skill_1, SkillId.Mon_boss_Zmei_Solo_Skill_2)]
	public class Mon_boss_Zmei_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 180f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 15f;
	}

	[SkillHandler(SkillId.Mon_event_gazer_Skill_2)]
	public class Mon_event_gazer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 120f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_event_Beeteros_Skill_2)]
	public class Mon_event_Beeteros_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 35f;
		protected override float Width { get; } = 0f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_event_Grummer_Skill_2)]
	public class Mon_event_Grummer_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(600);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 45f;
		protected override float Width { get; } = 35f;
		protected override float Angle { get; } = 30f;
	}

	[SkillHandler(SkillId.Mon_ep15_2_masma_Skill_2)]
	public class Mon_ep15_2_masma_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1500);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(1300);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_2_Papillon_Assassin_Skill_1)]
	public class Mon_ep15_2_Papillon_Assassin_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(300);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(100);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 5f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_2_Papillon_leader_Skill_1)]
	public class Mon_ep15_2_Papillon_leader_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(400);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(200);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_ep15_2_dark_statue_Skill_2)]
	public class Mon_ep15_2_dark_statue_Skill_2 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(1000);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(800);
		protected override SplashType SplashType { get; } = SplashType.Square;
		protected override float Length { get; } = 60f;
		protected override float Width { get; } = 10f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Slogutis_Q1_Skill_1)]
	public class Mon_boss_Slogutis_Q1_Skill_1 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(199999);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(199799);
		protected override SplashType SplashType { get; } = SplashType.Circle;
		protected override float Length { get; } = 30f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}

	[SkillHandler(SkillId.Mon_boss_Slogutis_Q1_Skill_4)]
	public class Mon_boss_Slogutis_Q1_Skill_4 : ParametersOnlySkill
	{
		protected override TimeSpan DamageDelay { get; } = TimeSpan.FromMilliseconds(10199);
		protected override TimeSpan HitDelay { get; } = TimeSpan.FromMilliseconds(9999);
		protected override SplashType SplashType { get; } = SplashType.Fan;
		protected override float Length { get; } = 20f;
		protected override float Width { get; } = 30f;
		protected override float Angle { get; } = 10f;
	}
}
