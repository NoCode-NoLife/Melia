namespace Melia.Channel.World
{
	/// <summary>
	/// Skill handler collection.
	/// </summary>
	public class SkillHandlers
	{
		/// <summary>
		/// Returns the default targeted skill handler.
		/// </summary>
		public TargetedSkillHandler TargetedSkillHandler { get; } = new TargetedSkillHandler();

		/// <summary>
		/// Returns the default grounded skill handler.
		/// </summary>
		public GroundSkillHandler GroundSkillHandler { get; } = new GroundSkillHandler();

		/// <summary>
		/// Returns the default targeted grounded skill handler.
		/// </summary>
		public TargetedGroundSkillHandler TargetedGroundSkillHandler { get; } = new TargetedGroundSkillHandler();
	}
}
