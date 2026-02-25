using Melia.Shared.Data.Database;

namespace Melia.Shared.Data
{
	/// <summary>
	/// Wrapper for all file databases.
	/// </summary>
	public class MeliaData
	{
		public AbilityDb AbilityDb = new();
		public AbilityTreeDb AbilityTreeDb = new();
		public AccountOptionDb AccountOptionDb = new();
		public AchievementDb AchievementDb = new();
		public AchievementPointDb AchievementPointDb = new();
		public BarrackDb BarrackDb = new();
		public BuffDb BuffDb = new();
		public ChatMacroDb ChatMacroDb = new();
		public CollectionDb CollectionDb;
		public CompanionDb CompanionDb = new();
		public CooldownDb CooldownDb = new();
		public CustomCommandDb CustomCommandDb = new();
		public DialogDb DialogDb = new();
		public DialogTxDb DialogTxDb = new();
		public ExpDb ExpDb = new();
		public FactionDb FactionDb = new();
		public FeatureDb FeatureDb = new();
		public GroundDb GroundDb = new();
		public HairTypeDb HairTypeDb = new();
		public HelpDb HelpDb = new();
		public InvBaseIdDb InvBaseIdDb = new();
		public ItemDb ItemDb = new();
		public ItemMonsterDb ItemMonsterDb = new();
		public JobDb JobDb = new();
		public MapDb MapDb = new();
		public MonsterDb MonsterDb = new();
		public NormalTxDb NormalTxDb = new();
		public PacketStringDb PacketStringDb = new();
		public PropertiesDb PropertiesDb = new();
		public RecipeDb RecipeDb = new();
		public ResurrectionPointDb ResurrectionPointDb = new();
		public ServerDb ServerDb;
		public SessionObjectDb SessionObjectDb = new();
		public ShopDb ShopDb = new();
		public SkillDb SkillDb = new();
		public SkillTreeDb SkillTreeDb = new();
		public SkinToneDb SkinToneDb = new();
		public StanceConditionDb StanceConditionDb = new();
		public SystemMessageDb SystemMessageDb = new();

		public MeliaData()
		{
			// Not entirely happy with this design, but I want access to
			// the map list from the server db to determine which maps
			// the zone servers serve.
			this.ServerDb = new(this.MapDb);

			// Yup, still not entirely happy with this.
			this.CollectionDb = new(this.PropertiesDb, this.ItemDb);
		}
	}
}
