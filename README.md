<div align="center">
  <img src="https://pan.samyyc.dev/s/VYmMXE" />
  <h2><strong>Sanky Sounds</strong></h2>
  <h3>A simple plugin for SwiftlyS2 that allows players with custom permission to play a sound in chat.</h3>
</div>

## Get Started

### Download Plugin

Download the plugin from the latest release and install it on your server.

### Requirements:
- **[SwiftlyS2]**(https://github.com/swiftly-solution/swiftlys2)
- **[AudioApi]**(https://github.com/SwiftlyS2-Plugins/Audio)

## Configuration

You can find the configuration file in `addons/swiftlys2/configs/plugins/Sanky_Sounds/config.jsonc` after the plugin has properly started up once.

```jsonc
{
  "SankySounds": {
    "ToggleSoundsCommands": [
      "sounds",
      "sk",
      "sankysounds"
    ],
    "Prefix": ".", // leave this empty if you don't want a prefix.
    "ShowMessages": true,
    "GlobalCooldown": 30, // in seconds
    "Permissions": [
      "sanky.admin",
      "76561199478674655" // works for both flags and steamid.
    ],
    "SankySounds": {
      "test,test1": "test.mp3" // path is data/Sanky_Sounds/
    }
  }
}
```
