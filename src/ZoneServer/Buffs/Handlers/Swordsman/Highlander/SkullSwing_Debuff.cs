using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Highlander
{
    /// <summary>
    /// Handler for SkullSwing_Debuff, which reduces Def
    /// </summary>
    /// <remarks>
    /// This buff stores its def drop in its NumArg2, since Vertical Slash
    /// uses it as a damage bonus
    /// </remarks>
    [BuffHandler(BuffId.ScullSwing_Debuff)]
    public class SkullSwing_Debuff : BuffHandler
    {
        /// <summary>
        /// Starts buff, reducing Def
        /// </summary>
        /// <param name="buff"></param>
        public override void OnStart(Buff buff)
        {
            var target = buff.Target;
            var reduceDef = target.Properties.GetFloat(PropertyName.DEF) * buff.NumArg2;

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
