# SCP 8585 Plugin

**Plugin Name**: SCP 8585 Plugin

**Version**: 1.0.0

**Author**: dzarenafixers

**dev**: moncef50g

## Description
The SCP 8585 Plugin for SCP: Secret Laboratory introduces a custom role named SCP 8585. SCP 8585 is a unique character that assists both SCP entities and Class-D personnel. This plugin allows server administrators to customize various aspects of SCP 8585, including health, identifier code, speed, and inventory items.

## Features
- **Custom Role**: Adds a new role named SCP 8585, which is based on the tutorial role.
- **Configurable Settings**: Allows server administrators to configure health, speed multiplier, and identifier code for SCP 8585 through the configuration file.
- **Inventory Setup**: Automatically equips SCP 8585 with specific items such as a COM-15 pistol and a medkit.
- **Speed Enhancement**: Increases the movement speed of SCP 8585 based on the configurable speed multiplier.
- **Intercom Access**: Allows SCP 8585 to communicate with SCP entities and Class-D personnel through the intercom.
- **Damage Immunity**: SCP 8585 has enhanced survivability with customizable health settings.
- **Broadcast Message**: Notifies the player when they are transformed into SCP 8585 with a custom message.

## Installation
1. **Download**: Download the compiled plugin DLL file.
2. **Place**: Place the DLL file in the `Exiled/Plugins` folder on your SCP: Secret Laboratory server.
3. **Configure**: Edit the configuration file to set the desired health, speed multiplier, and identifier code for SCP 8585.
4. **Launch**: Start your server.

## Configuration
The configuration file allows you to customize various aspects of SCP 8585. Below are the available options:

- `IsEnabled`: Enables or disables the plugin.
- `Scp8585Health`: Sets the health of SCP 8585. Default is 300.
- `Scp8585Code`: Sets the identifier code for SCP 8585. Default is "SCP-8585".
- `Scp8585SpeedMultiplier`: Sets the speed multiplier for SCP 8585. Default is 1.2.

### Example Configuration
```yaml
SCP8585Plugin:
  IsEnabled: true
  Scp8585Health: 300
  Scp8585Code: "SCP-8585"
  Scp8585SpeedMultiplier: 1.2
