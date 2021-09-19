using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace CuffedTK.Events 
{
    internal sealed class PlayerHandler 
    {
        // On Hurting
        public void onHurting(HurtingEventArgs ev) 
        {
            if (!ev.Target.IsCuffed) return;
            if(CuffedTK.Instance.Config.DisallowedDamageTypes.Contains(ev.DamageType.Name) && (ev.Target.Team == Team.CDP || ev.Target.Team == Team.RSC))
            {
                if (CuffedTK.Instance.Config.DamageTypesTime > 0)
                    ev.Attacker.ShowHint(CuffedTK.Instance.Config.DamageTypesMessage.Replace("%PLAYER%", ev.Target.Nickname).Replace("%DAMAGETYPE%", ev.DamageType.Name), CuffedTK.Instance.Config.DamageTypesTime);
                ev.IsAllowed = false;
                return;
            }

            if(ev.Target.Team == Team.CDP && CuffedTK.Instance.Config.DisallowDamagetodclass.Contains(ev.Attacker.Team))
            {
                if (CuffedTK.Instance.Config.AttackerHintTime > 0)
                    ev.Attacker.ShowHint(CuffedTK.Instance.Config.AttackerHint.Replace("%PLAYER%", ev.Target.Nickname), CuffedTK.Instance.Config.AttackerHintTime);
                ev.IsAllowed = false;
            } else if(ev.Target.Team == Team.RSC && CuffedTK.Instance.Config.DisallowDamagetoScientists.Contains(ev.Attacker.Team))
            {
                if(CuffedTK.Instance.Config.AttackerHintTime > 0)
                    ev.Attacker.ShowHint(CuffedTK.Instance.Config.AttackerHint.Replace("%PLAYER%", ev.Target.Nickname), CuffedTK.Instance.Config.AttackerHintTime);
                ev.IsAllowed = false;
            }
        }
    }
}