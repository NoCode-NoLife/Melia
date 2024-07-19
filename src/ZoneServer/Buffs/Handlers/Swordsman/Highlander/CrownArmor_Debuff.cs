using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Highlander
{
    /// <summary>
    /// Handler for CrownArmor_Debuff, which zeros Def
    /// </summary>
    [BuffHandler(BuffId.Crown_Armor_Debuff)]
    public class CrownArmor_Debuff : BuffHandler
    {
        /// <summary>
        /// Starts buff, zeroing def
        /// </summary>
        /// <param name="buff"></param>
        public override void OnStart(Buff buff)
        {
            var target = buff.Target;
            var reduceDef = target.Properties.GetFloat(PropertyName.DEF);

            AddPropertyModifier(buff, target, PropertyName.DEF_BM, -reduceDef);
        }

        /// <summary>
        /// Ends the buff, resetting Def
        /// </summary>
        /// <param name="buff"></param>
        public override void OnEnd(Buff buff)
        {
            RemovePropertyModifier(buff, buff.Target, PropertyName.DEF_BM);
        }
    }
}
