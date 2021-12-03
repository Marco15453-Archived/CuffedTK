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
Check [Here](https://exiled-team.github.io/EXILED/api/Exiled.API.Enums.DamageType.html) for all DamageTypes

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
  - Explosion
  - FriendlyFireDetector
  - Falldown
```
