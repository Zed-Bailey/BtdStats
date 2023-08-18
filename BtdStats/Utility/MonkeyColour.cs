namespace BtdStats.Utility;

public static class MonkeyColour
{
    
    static readonly List<string> PrimaryMonkeys = new()
    {
        "dart-monkey", "boomerang-monkey", "bomb-shooter", "tack-shooter", "ice-monkey", "glue-gunner"
    };

    static readonly List<string> MilitaryMonkeys = new()
    {
        "sniper-monkey", "monkey-sub", "monkey-buccaneer", "monkey-ace", "heli-pilot", "mortar-monkey", "dartling-gunner"
    };

    static readonly List<string> MagicMonkeys = new()
    {
        "wizard-monkey", "super-monkey", "ninja-monkey", "alchemist", "druid"
    };

    static readonly List<string> SupportMonkeys = new()
    {
        "banana-farm", "spike-factory", "monkey-village", "engineer-monkey"
    };
    
    /// <summary>
    /// Gets the colour for the monkey based on it's name
    /// </summary>
    /// <param name="id">the monkey's id</param>
    /// <returns>a css rgb colour string in the format rgb(0,0,0)</returns>
    public static string GetMonkeyColourByName(string id)
    {
        if (PrimaryMonkeys.Contains(id))
            return "rgb(128,195,230)";

        if (MilitaryMonkeys.Contains(id))
            return "rgb(159,240,137)";
        
        if (MagicMonkeys.Contains(id))
            return "rgb(175,128,245)";
        
        if (SupportMonkeys.Contains(id))
            return "rgb(244,193,133)";

        throw new ArgumentException($"Invalid monkey id. id={id}");
    }
    
    /// <summary>
    /// Gets the colour  for the monkey based on it's type
    /// </summary>
    /// <param name="type"></param>
    /// <returns>a css rgb colour string in the format rgb(0,0,0)</returns>
    /// <exception cref="ArgumentException">if an invalid type is passed in</exception>
    public static string GetMonkeyColourByType(string type)
    {
        return type.ToLowerInvariant() switch
        {
            "primary" => "rgb(128,195,230)",
            "military" => "rgb(159,240,137)",
            "magic" => "rgb(175,128,245)",
            "support" => "rgb(244,193,133)",
            _ => throw new ArgumentException($"Invalid monkey type. invalid type = {type}")
        };
    }
}