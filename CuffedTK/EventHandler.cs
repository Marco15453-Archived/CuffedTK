using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using System.Linq;

namespace CuffedTK
{
    internal sealed class EventHandler
    {
        public CuffedTK plugin;
        public EventHandler(CuffedTK plugin) => this.plugin = plugin;

        public void onHurting(HurtingEventArgs ev)
        {
            if (!ev.Target.IsCuffed) return;

            if (plugin.Config.DisallowedDamageTypes.Contains(ev.Handler.Type) && (ev.Target.Team == Team.CDP || ev.Target.Team == Team.RSC))
            {
                if (plugin.Config.DamageTypesTime > 0)
                    ev.Attacker.ShowHint(plugin.Config.DamageTypesMessage.Replace("%PLAYER%", ev.Target.Nickname).Replace("%DAMAGETYPE%", ev.Handler.Type.ToString()), plugin.Config.DamageTypesTime);
                ev.IsAllowed = false;
            }
            else if ((ev.Target.Team == Team.CDP && plugin.Config.DisallowDamagetodclass.Contains(ev.Attacker.Team)) || (ev.Target.Team == Team.RSC && plugin.Config.DisallowDamagetoScientists.Contains(ev.Attacker.Team)))
            {
                if (plugin.Config.AttackerHintTime > 0)
                    ev.Attacker.ShowHint(plugin.Config.AttackerHint.Replace("%PLAYER%", ev.Target.Nickname), plugin.Config.AttackerHintTime);
                ev.IsAllowed = false;
            }
        }
    }
}
