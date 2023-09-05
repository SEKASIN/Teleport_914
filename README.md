# Teleport_914
EXILED plugin that teleports people out of SCP-914 in exchange of health.

## Installation
Download teleport_914.dll from [Releases](https://github.com/SEKASIN/Teleport_914/blob/master/Releases)\
Move Teleport_914.dll to .config/EXILED/Plugins and restart server.

## Configuration
Edit values in .config/EXILED/Configs/PORT-config.yml\
Example config with default values:
```
teleport_914:
# Is the Plugin enabled.
  is_enabled: true
  # Debug mode.
  debug: false
  # How many percentages should a player lose when trying to teleport. Give a value between 0 and 1.
  health_loss_percentage: 0.29999999999999999
  # What is the chance that a person will teleport out. Give a value between 0 and 100
  teleport_chance: 50
  # Determines what rooms can be teleported to using SCP-914 teleportation.
  teleport_rooms:
  - LczCafe
  - LczCrossing
  - LczStraight
  - LczTCross
  - LczPlants
  - LczClassDSpawn
  - LczGlassBox
  - LczToilets
  - LczAirlock
```
- is_enabled
> A boolean; Controls if IDS is enabled or not.
- debug
> A boolean; Enables some extra logging.
- health_loss_percentage
> A double; How much of the person's hp should be lost in percentages.
- teleport_chance
> An int; What is the chance that the person will be teleported out.
- teleport_rooms
> A list of RoomTypes; What areas it is possible to teleport to.
