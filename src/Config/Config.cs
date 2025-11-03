namespace Sanky_Sounds;

public class PluginConfig
{
    public List<string> ToggleSoundsCommands { get; set; } = ["sounds", "sk", "sankysounds"];
    public string Prefix { get; set; } = ".";
    public bool ShowMessages { get; set; } = true;
    public int GlobalCooldown { get; set; } = 30;
    public List<string> Permissions { get; set; } = ["sanky.admin", "76561199478674655"];
    public Dictionary<string, string> SankySounds { get; set; } = new()
    {
        { "test,test1", "test.mp3" }
    };
}
