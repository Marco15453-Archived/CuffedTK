using Exiled.API.Interfaces;
using Exiled.API.Enums;
using System.ComponentModel;
using System.Collections.Generic;

namespace CuffedTK {
    public sealed class Config : IConfig {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

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
