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

            if(ev.Target.Team == Team.CDP)
            {
                if (!CuffedTK.Instance.Config.DisallowDamagetodclass.Contains(ev.Attacker.Team)) return;

                if (CuffedTK.Instance.Config.AttackerBroadcastTime > 0)
                    ev.Attacker.Broadcast(CuffedTK.Instance.Config.AttackerBroadcastTime, CuffedTK.Instance.Config.AttackerBroadcast.Replace("%PLAYER%", ev.Target.Nickname));
                ev.IsAllowed = false;
                return;
            } else if(ev.Target.Team == Team.RSC)
            {
                if (!CuffedTK.Instance.Config.DisallowDamagetoScientists.Contains(ev.Attacker.Team)) return;

                if(CuffedTK.Instance.Config.AttackerBroadcastTime > 0)
                    ev.Attacker.Broadcast(CuffedTK.Instance.Config.AttackerBroadcastTime, CuffedTK.Instance.Config.AttackerBroadcast.Replace("%PLAYER%", ev.Target.Nickname));
                ev.IsAllowed = false;
                return;
            }
        }
    }
}