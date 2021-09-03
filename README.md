# CuffedTK
A simple plugin that prevents Cuffed Players be damaged by MTF or Facility Guards

# Team
Short | Full
----- | ----
CDP | Class-D Personnel
CHI | Chaos Insurgency
MTF | Nine-Tailed Fox
RSC | Scientists
TUT | Tutorial

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | Is the plugin enabled? | true
send_attacker_broadcast | bool | Should the Attacker be broadcasted that he can't damage an Cuffed D-Class? | true
attacker_broadcast_time | ushort | For how long should the broadcast be shown? | 3
attacker_broadcast | string | What should the Attacker be broadcasted when trying to damage a Cuffed D-Class? {PLAYER} will be replaced with the Target Username | You cannot damage {PLAYER} because he is cuffed! 
disallow_damagetodclass | bool | What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial | false, false, true, true, false 

# Default Config
```yml
cuffed_t_k:
# Should the plugin be enabled?
  is_enabled: true
  # What Team should not be allowed to damage an Cuffed D-Class! CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial
  disallow_damagetodclass:
    CDP: false
    CHI: false
    MTF: true
    RSC: true
    TUT: false
```