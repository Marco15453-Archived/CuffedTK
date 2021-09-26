using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace CuffedTK.Events 
{
    internal sealed class PlayerHandler 
    {
        public CuffedTK plugin;
        public PlayerHandler(CuffedTK plugin) => this.plugin = plugin;

        // On Hurting
        public void onHurting(HurtingEventArgs ev) 
        {
            if (!ev.Target.IsCuffed) return;
            if(plugin.Config.DisallowedDamageTypes.Contains(ev.DamageType.Name) && (ev.Target.Team == Team.CDP || ev.Target.Team == Team.RSC))
            {
                if (plugin.Config.DamageTypesTime > 0)
                    ev.Attacker.ShowHint(plugin.Config.DamageTypesMessage.Replace("%PLAYER%", ev.Target.Nickname).Replace("%DAMAGETYPE%", ev.DamageType.Name), plugin.Config.DamageTypesTime);
                ev.IsAllowed = false;
            } else if((ev.Target.Team == Team.CDP && plugin.Config.DisallowDamagetodclass.Contains(ev.Attacker.Team)) || (ev.Target.Team == Team.RSC && plugin.Config.DisallowDamagetoScientists.Contains(ev.Attacker.Team))) {
                if (plugin.Config.AttackerHintTime > 0)
                    ev.Attacker.ShowHint(plugin.Config.AttackerHint.Replace("%PLAYER%", ev.Target.Nickname), plugin.Config.AttackerHintTime);
                ev.IsAllowed = false;
            }
        }
    }
}