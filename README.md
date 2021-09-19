# CuffedTK
A simple plugin that prevents Cuffed Players be damaged by configureable Teams and/or Damaged Type

# Team
Short | Full
----- | ----
CDP | Class-D Personnel
CHI | Chaos Insurgency
MTF | Nine-Tailed Fox
RSC | Scientists
SCP | SCP
TUT | Tutorial

# Damage Types
Short | Full
----- | ----
AK | Damaged By AK
ASPHYXIATION | Damaged by ASPHYXIATION
BLEEDING | Damaged by BLEEDING
COM15 | Damaged by COM15
COM18 | Damaged by COM-18 Pistol
CONTAIN | Being Damaged by Contain
CROSSVEC | Damaged by CrossVEC
DECONT | Damaged by Decontainment
E11SR | Damaged by E11SR
FALLDOWN | Damaged by FALLDOWN
Flying detection | Damaged by Flying Detection
Friendly fire detector | Damaged by Friendly Fire Detector
FSP9 | Damaged by FSP9
GRENADE | Damaged by Grenade
LOGICER | Damaged by Logicer
LURE | Damaged by SCP-106 Containment Chamber when you enter it
MICROHID | Damaged by Micro-HID
NUKE | Damaged by Nuke
POCKET | Damaged by Pocket Dimension
POISONED | Damaged by Poison
RAGDOLL-LESS | Damage Type when player dies without leaving a ragdoll (for example, changing role)
RECONTAINMENT | Damaged by Recontainment
REVOLVER | Damaged by Revolver
SCP-018 | Damaged by SCP-018
SCP-049 | Damaged by SCP-049
SCP-049-2 | Damaged by SCP-049-2
SCP-096 | Damaged by SCP-096
SCP-106 | Damaged by SCP-106
SCP-173 | Damaged by SCP-173
SCP-207 | Damaged by SCP-207
SCP-939 | Damaged by SCP-939
SHOTGUN | Damaged by Shotgun
TESLA | Damaged by Tesla
WALL | -/-

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | Is the plugin enabled? | true
attacker_hint_time | ushort | For how long should the Hint be shown to the Attacker? (-1 = Disabled) | 3
attacker_hint | string | What hint should the Attacker be displayed when trying to damage a Cuffed D-Class? %PLAYER% will be replaced with the Target Username | You cannot damage %PLAYER% because he is cuffed! 
disallow_damagetodclass | HashSet | What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial | MTF, RSC
disallow_damageto_scientists | HashSet | What Team should not be allowed to damage an Cuffed Scientists! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial | CDP, CHI
damage_types_time | int | For how long should the hint be shown to the Attacker? (-1 = Disabled) | 3
damage_types_message | string | What hint should be displayed when trying to damage a Cuffed D-Class with a Disallowed DamageType? %PLAYER% will be replaced with the Target Username and %DAMAGETYPE% will be replaced with the DamageType | You cannot damage %PLAYER% with %DAMAGETYPE%!
disallowed_damage_types | Hashset | What DamageType should not be allowed to damage a Cuffed D-Class or Cuffed Scientist? Check https://github.com/Marco15453/CuffedTK#damage-types for all DamageTypes | FriendlyFireDetector, Falldown

# Default Config
```yml
cuffed_t_k:
  # Should the plugin be enabled?
  is_enabled: true
  # For how long should the Hint be shown to the Attacker? (-1 = Disabled)
  attacker_hint_time: 3
  # What hint should the Attacker be displayed when trying to damage a Cuffed D-Class? %PLAYER% will be replaced with the Target Username
  attacker_hint: You cannot damage %PLAYER% because he is cuffed!
  # What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial
  disallow_damagetodclass:
  - MTF
  - RSC
  # What Team should not be allowed to damage an Cuffed Scientists! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial
  disallow_damageto_scientists:
  - CDP
  - CHI
  # For how long should the hint be shown to the Attacker? (-1 = Disabled)
  damage_types_time: 3
  # What hint should be displayed when trying to damage a Cuffed D-Class with a Disallowed DamageType? %PLAYER% will be replaced with the Target Username and %DAMAGETYPE% will be replaced with the DamageType
  damage_types_message: You cannot damage %PLAYER% with %DAMAGETYPE%!
  # What DamageType should not be allowed to damage a Cuffed D-Class or Cuffed Scientist? Check https://github.com/Marco15453/CuffedTK#damage-types for all DamageTypes
  disallowed_damage_types:
  - Friendly fire detector
  - FALLDOWN
  - GRENADE
```
