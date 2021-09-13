using Exiled.API.Interfaces;
using Exiled.API.Enums;
using System.ComponentModel;
using System.Collections.Generic;

namespace CuffedTK 
{
    public sealed class Config : IConfig 
    {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should the plugin automaticly update?")]
        public bool AutoUpdate { get; set; } = true;

        [Description("For how long should the Hint be shown to the Attacker? (-1 = Disabled)")]
        public ushort AttackerHintTime { get; set; } = 3;

        [Description("What hint should the Attacker be displayed when trying to damage a Cuffed D-Class? %PLAYER% will be replaced with the Target Username")]
        public string AttackerHint { get; set; } = "You cannot damage %PLAYER% because he is cuffed!";

        [Description("What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial")]
        public HashSet<Team> DisallowDamagetodclass { get; set; } = new HashSet<Team>
        {
            Team.MTF,
            Team.RSC
        };

        [Description("What Team should not be allowed to damage an Cuffed Scientists! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial")]
        public HashSet<Team> DisallowDamagetoScientists { get; set; } = new HashSet<Team>
        {
            Team.CDP,
            Team.CHI
        };

        [Description("For how long should the hint be shown to the Attacker? (-1 = Disabled)")]
        public int DamageTypesTime { get; set; } = 3;

        [Description("What hint should be displayed when trying to damage a Cuffed D-Class with a Disallowed DamageType? %PLAYER% will be replaced with the Target Username and %DAMAGETYPE% will be replaced with the DamageType")]
        public string DamageTypesMessage { get; set; } = "You cannot damage %PLAYER% with %DAMAGETYPE%!";

        [Description("What DamageType should not be allowed to damage a Cuffed D-Class or Cuffed Scientist? Check https://github.com/Marco15453/CuffedTK#damage-types for all DamageTypes")]
        public HashSet<string> DisallowedDamageTypes { get; set; } = new HashSet<string>
        {
            DamageTypes.FriendlyFireDetector.Name,
            DamageTypes.Falldown.Name
        };
    }
}
