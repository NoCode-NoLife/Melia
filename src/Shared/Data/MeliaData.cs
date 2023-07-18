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
		public AccountOptionDb AccountOptionDb = new AccountOptionDb();
		public AchievementDb AchievementDb = new AchievementDb();
		public AchievementPointDb AchievementPointDb = new AchievementPointDb();
		public BarrackDb BarrackDb = new BarrackDb();
		public BuffDb BuffDb = new BuffDb();
		public ChatMacroDb ChatMacroDb = new ChatMacroDb();
		public CustomCommandDb CustomCommandDb = new CustomCommandDb();
		public CooldownDb CooldownDb = new CooldownDb();
		public DialogDb DialogDb = new DialogDb();
		public DialogTxDb DialogTxDb = new DialogTxDb();
		public ExpDb ExpDb = new ExpDb();
		public FeatureDb FeatureDb = new FeatureDb();
		public FactionDb FactionDb = new FactionDb();
		public GroundDb GroundDb = new GroundDb();
		public InvBaseIdDb InvBaseIdDb = new InvBaseIdDb();
		public ItemDb ItemDb = new ItemDb();
		public ItemMonsterDb ItemMonsterDb = new ItemMonsterDb();
		public JobDb JobDb = new JobDb();
		public MapDb MapDb = new MapDb();
		public MonsterDb MonsterDb = new MonsterDb();
		public NormalTxDb NormalTxDb = new NormalTxDb();
		public PacketStringDb PacketStringDb = new PacketStringDb();
		public PropertiesDb PropertiesDb = new PropertiesDb();
		public RecipeDb RecipeDb = new RecipeDb();
		public ResurrectionPointDb ResurrectionPointDb = new ResurrectionPointDb();
		public ServerDb ServerDb;
		public SessionObjectDb SessionObjectDb = new SessionObjectDb();
		public ShopDb ShopDb = new ShopDb();
		public SkillDb SkillDb = new SkillDb();
		public SkillTreeDb SkillTreeDb = new SkillTreeDb();
		public StanceConditionDb StanceConditionDb = new StanceConditionDb();
		public SystemMessageDb SystemMessageDb = new SystemMessageDb();
		public HelpDb HelpDb = new HelpDb();

		public MeliaData()
		{
			// Not entirely happy with this design, but I want access to
			// the map list from the server db to determine which maps
			// the zone servers serve.
			this.ServerDb = new ServerDb(this.MapDb);
		}
	}
}
