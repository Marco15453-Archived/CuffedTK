using Exiled.API.Interfaces;
using Exiled.API.Enums;
using System.ComponentModel;
using System.Collections.Generic;

namespace CuffedTK {
    public sealed class Config : IConfig {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should the Attacker be broadcasted that he can't damage an Cuffed D-Class?")]
        public bool sendAttackerBroadcast { get; set; } = true;

        [Description("For how long should the broadcast be shown?")]
        public ushort AttackerBroadcastTime { get; set; } = 3;

        [Description("What should the Attacker be broadcasted when trying to damage a Cuffed D-Class? {PLAYER} will be replaced with the Target Username")]
        public string AttackerBroadcast { get; set; } = "You cannot damage {PLAYER} because he is cuffed!";

        [Description("What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial")]
        public Dictionary<Team, bool> DisallowDamagetodclass { get; set; } = new Dictionary<Team, bool> {
            { Team.CDP, false },
            { Team.CHI, false },
            { Team.MTF, true },
            { Team.RSC, true },
            { Team.TUT, false }
        };
    }
}
