using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace CuffedTK.Events {
    internal sealed class PlayerHandler {
        
        // On Hurting
        public void onHurting(HurtingEventArgs ev) {
            if (!ev.Target.IsCuffed) return;

            if(ev.Target.Team == Team.CDP) {
                if (CuffedTK.Instance.Config.DisallowDamagetodclass.TryGetValue(ev.Attacker.Team, out bool value) && !value) return;

                if(CuffedTK.Instance.Config.sendAttackerBroadcast) {
                    string message = CuffedTK.Instance.Config.AttackerBroadcast.Replace("{PLAYER}", ev.Target.Nickname);
                    ev.Attacker.Broadcast(CuffedTK.Instance.Config.AttackerBroadcastTime, message, Broadcast.BroadcastFlags.Normal, false);
                }

                ev.IsAllowed = false;
                return;
            }
        }
    }
}