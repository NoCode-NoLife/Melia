using Melia.Shared.Data.Database;

namespace Melia.Shared.Data
{
	/// <summary>
	/// Wrapper for all file databases.
	/// </summary>
	public class MeliaData
	{
		public AbilityDb AbilityDb = new AbilityDb();
		public AbilityTreeDb AbilityTreeDb = new AbilityTreeDb();
		public AchievementDb AchievementDb = new AchievementDb();
		public AnimationIdDb AnimationIdDb = new AnimationIdDb();
		public BarrackDb BarrackDb = new BarrackDb();
		public BuffDb BuffDb = new BuffDb();
		public ChatMacroDb ChatMacroDb = new ChatMacroDb();
		public CustomCommandDb CustomCommandDb = new CustomCommandDb();
		public CooldownDb CooldownDb = new CooldownDb();
		public DialogDb DialogDb = new DialogDb();
		public ExpDb ExpDb = new ExpDb();
		public GroundDb GroundDb = new GroundDb();
		public InvBaseIdDb InvBaseIdDb = new InvBaseIdDb();
		public ItemDb ItemDb = new ItemDb();
		public ItemMonsterDb ItemMonsterDb = new ItemMonsterDb();
		public JobDb JobDb = new JobDb();
		public MapDb MapDb = new MapDb();
		public MonsterDb MonsterDb = new MonsterDb();
		public ServerDb ServerDb = new ServerDb();
		public SessionObjectDb SessionObjectDb = new SessionObjectDb();
		public ShopDb ShopDb = new ShopDb();
		public SkillDb SkillDb = new SkillDb();
		public SkillTreeDb SkillTreeDb = new SkillTreeDb();
		public StanceConditionDb StanceConditionDb = new StanceConditionDb();
		public HelpDb HelpDb = new HelpDb();
	}
}
