using System;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Zone.Scripting;

namespace Melia.Zone.Skills
{
	/// <summary>
	/// Properties of a skill.
	/// </summary>
	public class SkillProperties : Properties
	{
		/// <summary>
		/// Returns the skill these properties belong to.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Returns the skill's HitDelay property as a TimeSpan.
		/// </summary>
		public TimeSpan HitDelay => TimeSpan.FromMilliseconds(this.GetFloat(PropertyName.HitDelay));

		/// <summary>
		/// Returns the skill's Skill_Delay property as a TimeSpan.
		/// </summary>
		public TimeSpan Delay => TimeSpan.FromMilliseconds(this.GetFloat(PropertyName.Skill_Delay));

		/// <summary>
		/// Returns the skill's ShootTime property as a TimeSpan.
		/// </summary>
		public TimeSpan ShootTime => TimeSpan.FromMilliseconds(this.GetFloat(PropertyName.ShootTime));

		/// <summary>
		/// Creates new properties instance for the given skill.
		/// </summary>
		/// <param name="skill"></param>
		public SkillProperties(Skill skill) : base("Skill")
		{
			this.Skill = skill;
			this.AddDefaultProperties();
		}

		/// <summary>
		/// Adds default properties based on the skill's properties and data.
		/// </summary>
		private void AddDefaultProperties()
		{
			// I don't know what exactly LevelByDB's purpose is, but if
			// it's not sent, skills can be leveled past their max level.
			// It's like that's the value the client uses to calculate
			// the current max level.

			this.Create(new RFloatProperty(PropertyName.Level, () => this.Skill.Level));
			this.Create(new RFloatProperty(PropertyName.LevelByDB, () => this.Skill.Level));

			this.Create(new RFloatProperty(PropertyName.SpendSP, () => this.CalculateProperty("SCR_Get_SpendSP")));
			this.Create(new RFloatProperty(PropertyName.SpendSta, () => this.CalculateProperty("SCR_Skill_STA")));

			this.Create(new RFloatProperty(PropertyName.SklWaveLength, () => this.Skill.Data.WaveLength));
			this.Create(new RFloatProperty(PropertyName.SplHeight, () => this.Skill.Data.SplashHeight));
			this.Create(new RFloatProperty(PropertyName.SklSplAngle, () => this.Skill.Data.SplashAngle));
			this.Create(new RFloatProperty(PropertyName.SklSplRange, () => this.Skill.Data.SplashRange));
			this.Create(new RFloatProperty(PropertyName.WaveLength, () => this.CalculateProperty("SCR_Get_WaveLength")));
			this.Create(new RFloatProperty(PropertyName.SplAngle, () => this.CalculateProperty("SCR_SPLANGLE")));
			this.Create(new RFloatProperty(PropertyName.SplRange, () => this.CalculateProperty("SCR_Get_SplRange")));

			// While a property named SR exists for skills, it doesn't seem
			// to be used in the property calculations. Instead, there's
			// SklSR, which is used in combination with PC.SR in the
			// calculation of SkillSR. Confused yet? =) No =<? Did I
			// mention there's also multiple SkillSR calculation functions
			// and that each skill can define its own? We'll probably not
			// do that...
			//this.Create(new RFloatProperty(PropertyName.SR, () => this.Skill.Data.SplashRate));
			this.Create(new RFloatProperty(PropertyName.SklSR, () => this.Skill.Data.SplashRate));
			this.Create(new RFloatProperty(PropertyName.SkillSR, () => this.CalculateProperty("SCR_GET_SR_LV")));

			this.Create(new RFloatProperty(PropertyName.SklFactor, () => this.CalculateProperty("SCR_Get_SklFactor")));
			this.Create(new RFloatProperty(PropertyName.SklFactorByLevel, () => this.CalculateProperty("SCR_Get_SklFactorByLevel")));
			this.Create(new RFloatProperty(PropertyName.SkillFactor, () => this.CalculateProperty("SCR_Get_SkillFactor")));
			this.Create(new RFloatProperty(PropertyName.SklAtkAdd, () => this.Skill.Data.AtkAdd));
			this.Create(new RFloatProperty(PropertyName.SklAtkAddByLevel, () => this.Skill.Data.AtkAddByLevel));
			this.Create(new RFloatProperty(PropertyName.SkillAtkAdd, () => this.CalculateProperty("SCR_Get_SkillAtkAdd")));

			this.Create(new RFloatProperty(PropertyName.MaxR, () => this.Skill.Data.MaxRange));
			this.Create(new RFloatProperty(PropertyName.CoolDown, () => (int)this.Skill.Data.CooldownTime.TotalMilliseconds));
			this.Create(new RFloatProperty(PropertyName.HitDelay, () => (int)this.Skill.Data.DefaultHitDelay.TotalMilliseconds));
			this.Create(new RFloatProperty(PropertyName.AbleShootRotate, () => 0f));
			this.Create(new RFloatProperty(PropertyName.SpendPoison, () => 0f));
			this.Create(new RFloatProperty(PropertyName.ReadyTime, () => 0f));
			this.Create(new RFloatProperty(PropertyName.SkillAtkAdd, () => 0f));
			this.Create(new RFloatProperty(PropertyName.UseOverHeat, () => this.CalculateProperty("SCR_GET_USEOVERHEAT")));
			this.Create(new RFloatProperty(PropertyName.SkillASPD, () => 1f));
			this.Create(new RFloatProperty(PropertyName.BackHitRange, () => 0f));
			this.Create(new RFloatProperty(PropertyName.DelayTime, () => (int)this.Skill.Data.DelayTime.TotalMilliseconds));
			this.Create(new RFloatProperty(PropertyName.Skill_Delay, () => this.CalculateProperty("SCR_GET_DELAY_TIME")));
			this.Create(new RFloatProperty(PropertyName.ReinforceAtk, () => 0f));

			this.Create(new RFloatProperty(PropertyName.SklSpdRateValue, () => this.Skill.Data.SpeedRate));
			this.Create(new RFloatProperty(PropertyName.SklSpdRate, () => this.CalculateProperty("SCR_GET_SklSpdRate")));
			this.Create(new RFloatProperty(PropertyName.ShootTime, () => this.CalculateProperty("SCR_GET_ShootTime")));

			// We previously had this as `Enable ? 1 : 0`, but it seems like
			// EnableShootMove actually needs to be 0 to allow movement while
			// shooting.
			this.Create(new RFloatProperty(PropertyName.EnableShootMove, () => this.Skill.Data.EnableCastMove ? 0f : 1f));

			this.Create(new RFloatProperty(PropertyName.CaptionTime, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Create(new RFloatProperty(PropertyName.CaptionRatio, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Create(new RFloatProperty(PropertyName.CaptionRatio2, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Create(new RFloatProperty(PropertyName.CaptionRatio3, () => 0f)); // Needs to be calculated if used, uses lua script
		}

		/// <summary>
		/// Creates a new calculated float property that uses the given
		/// function.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="calcFuncName"></param>
		//private void Create(string propertyName, string calcFuncName)
		//{
		//	this.Create(new CFloatProperty(propertyName, () => this.CalculateProperty(calcFuncName)));
		//}

		/// <summary>
		/// Calls the calculation function with the given name and returns
		/// the result.
		/// </summary>
		/// <param name="calcFuncName"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the function doesn't exist.
		/// </exception>
		private float CalculateProperty(string calcFuncName)
		{
			// Custom calculation methods can be defined for skills by
			// creating functions that are suffixed with the skill class
			// name.
			if (!ScriptableFunctions.Skill.TryGet(calcFuncName + "_" + this.Skill.Data.ClassName, out var func))
			{
				if (!ScriptableFunctions.Skill.TryGet(calcFuncName, out func))
					throw new ArgumentException($"Scriptable skill function '{calcFuncName}' not found.");
			}

			return func(this.Skill);
		}
	}
}
