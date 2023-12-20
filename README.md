# Grand Theft Auto 2 - Savegame Editor
This is a standalone savegame editor for Grand Theft Auto 2. With this tool, you can change ammunition for every weapon, as well as
change cash, health, armor, lives, wanted level. You can also enable power-ups, including Invulnerability, Invisibility, Double Damage,
Fast Reload, and ElectroFingers. To use this tool, simply navigate to the [Release](https://github.com/JulianOzelRose/GTA2-SaveEdit/tree/master/GTA2-SaveEdit/bin/x64/Release)
folder, then download and run ```GTA2-SaveEdit.exe```. No installation is necessary; simply download and run. To edit a savegame, navigate
to your GTA 2 directory. GTA 2 savegame files are in .svg format. It should be located in: <br>

```C:\Program Files (x86)\Rockstar Games\GTA2\player```<br>

This tool automatically creates backups of your savegame as a precaution, which will have the identical name to the original save with ".bak"
added to the end. Once a savegame is loaded, you can modify to your desire. You can click ```Reload``` to update the values after saving through the game.
Note that ammo values max out at 255, but will reset to 99 when picking up ammo in game. Lives and the point multiplier max out at 255, but reset to 99
when the game is saved. Enabling power-ups sets a hacked time value, so they will last around 45 minutes. When they wear off, saving and reloading will reactive them.

![GTA2-SaveEdit-UI](https://github.com/JulianOzelRose/GTA2-SaveEdit/assets/95890436/314d21aa-07cc-40ff-8d57-d5b0602b76ea)
