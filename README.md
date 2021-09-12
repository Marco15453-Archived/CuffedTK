# CuffedTK
A simple plugin that prevents Cuffed Players be damaged by configureable Teams

# Team
Short | Full
----- | ----
CDP | Class-D Personnel
CHI | Chaos Insurgency
MTF | Nine-Tailed Fox
RSC | Scientists
SCP | SCP
TUT | Tutorial

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | Is the plugin enabled? | true
auto_update | bool | Should the plugin automaticly update? | true
attacker_broadcast_time | ushort | For how long should the broadcast be shown to the Attacker? (-1 = Disabled) | 3
attacker_broadcast | string | What should the Attacker be broadcasted when trying to damage a Cuffed D-Class? %PLAYER% will be replaced with the Target Username | You cannot damage %PLAYER% because he is cuffed! 
disallow_damagetodclass | HashSet | What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial | MTF, RSC
disallow_damageto_scientists | HashSet | What Team should not be allowed to damage an Cuffed Scientists! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial | CDP, CHI

# Default Config
```yml
cuffed_t_k:
  # Should the plugin be enabled?
  is_enabled: true
  # Should the plugin automaticly update?
  auto_update: true
  # For how long should the broadcast be shown to the Attacker? (-1 = Disabled)
  attacker_broadcast_time: 3
  # What should the Attacker be broadcasted when trying to damage a Cuffed D-Class? %PLAYER% will be replaced with the Target Username
  attacker_broadcast: You cannot damage %PLAYER% because he is cuffed!
  # What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial
  disallow_damagetodclass:
  - MTF
  - RSC
  # What Team should not be allowed to damage an Cuffed Scientists! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial
  disallow_damageto_scientists:
  - CDP
  - CHI
```
