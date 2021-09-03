using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace CuffedTK.Events {
    internal sealed class PlayerHandler {
        
        // On Hurting
        public void onHurting(HurtingEventArgs ev) {
            if (!ev.Target.IsCuffed) return;

            if(ev.Target.Team == Team.CDP) {
                if (CuffedTK.Instance.Config.DisallowDamageToDClass.TryGetValue(ev.Attacker.Team, out bool value) && !value) return;

                ev.IsAllowed = false;
                return;
            }
        }
    }
}