# Grand Theft Auto 2 - Savegame Editor
This is a standalone savegame editor for Grand Theft Auto 2. With this tool, you can change ammunition for every weapon, as well as
change cash, health, armor, lives, wanted level. You can also enable power-ups, including Invulnerability, Invisibility, Double Damage,
Fast Reload, and ElectroFingers. For more information and instructions on how to use this tool, scroll down to the section below.
You can also find information on reverse engineering GTA 2 savegames, along with an offset table at the bottom of this README.

![GTA2-SaveEdit-UI](https://github.com/JulianOzelRose/GTA2-SaveEdit/assets/95890436/314d21aa-07cc-40ff-8d57-d5b0602b76ea)

## Installation and use
To use the latest stable release of this tool, simply navigate to the [Releases](https://github.com/JulianOzelRose/GTA2-SaveEdit/releases)
section, then download and run `GTA2-SaveEdit-v1.03.exe`. No installation is necessary; simply download and run. To edit a savegame, navigate
to your GTA 2 directory. GTA 2 savegame files are in `.svg` format. They should be located in the following directory: <br>

`C:\Program Files (x86)\Rockstar Games\GTA2\player`<br>

This tool automatically creates backups of your savegame as a precaution, which will have the identical name to the original save with ".bak"
added to the end. Once a savegame is loaded, you can modify to your desire. You can click "Reload" to update the values after saving through the game.
Note that ammo values max out at 255, but will reset to 99 when picking up ammo in game. Lives and the point multiplier max out at 255, but reset to 99
when the game is saved. Enabling power-ups sets a hacked time value, so they will last around 45 minutes. When they wear off, saving and reloading
the game will reactivate them.

## Offset table
Most of these values are stored as Int8, with the exception of cash which is of Int32 type. There is no enabling or disabling weapons;
simply giving a weapon an ammo value will enable it, and setting the ammo to 0 will disable it. For the power-ups, a value of 0 indicates
the power-up is inactive. Similar to ammo, there is no enabling or disabling power-ups; the variable is essentially a timer value. Each
byte corresponds to approximately 10 seconds, so setting a power-up to 0xFF will activate it for around 45 minutes.

| **File offset**    | **Type**       | **Variable**                      |
| :---               | :---           | :---                              |
| 0x64               | Int32          | Cash                              |
| 0x68               | Int8           | Lives                             |
| 0x6C               | Int8           | Health                            |
| 0x74               | Int8           | Armor                             |
| 0x76               | Int8           | Get Outta Jail Free Card Power-Up |
| 0x7B               | Int8           | Invulnerability Power-Up          |
| 0x7D               | Int8           | Double Damage Power-Up            |
| 0x7F               | Int8           | Fast Reload Power-Up              |
| 0x81               | Int8           | ElectroFingers Power-Up           |
| 0x85               | Int8           | Invisibility Power-Up             |
| 0xBA               | Int8           | Pistol Ammo                       |
| 0xBB               | Int8           | S-Uzi Machine Gun Ammo            |
| 0xBC               | Int8           | Rocket Launcher Ammo              |
| 0xBD               | Int8           | ElectroGun Ammo                   |
| 0xBE               | Int8           | Molotov Cocktails                 |
| 0xBF               | Int8           | Grenades                          |
| 0xC0               | Int8           | Shotgun Ammo                      |
| 0xC1               | Int8           | ElectroBaton Ammo                 |
| 0xC2               | Int8           | Flamethrower Ammo                 |
| 0xC3               | Int8           | Silenced S-Uzi Machine Gun Ammo   |
| 0xC4               | Int8           | Dual Pistol Ammo                  |
| 0xD4               | Int8           | Point Multiplier                  |
| 0xD6               | Int8           | Weapon Equipped                   |
| 0xE1               | Int8           | Wanted Level                      |
