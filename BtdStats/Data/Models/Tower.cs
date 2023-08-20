namespace BtdStats.Data.Models;


public static class TowerExtensions
{
    /// <summary>
    /// Extension function to return the cost for a specified game mode
    /// </summary>
    /// <param name="cost"></param>
    /// <param name="difficulty"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static int SelectCost(this Cost cost, int difficulty)
    {
        return difficulty switch
        {
            0 => cost.Easy,
            1 => cost.Medium,
            2 => cost.Hard,
            3 => cost.Impoppable,
            _ => throw new ArgumentException($"Invalid difficulty: {difficulty}")
        };
    }
}
public record Cost(
    int Easy,
    int Medium,
    int Hard,
    int Impoppable
);

public record Paragon(
    string Name,
    string Description,
    Cost Cost,
    int UnlockXp,
    IReadOnlyList<string> Effects,
    string Source
);

public record Path1(
    string Name,
    string Description,
    Cost Cost,
    int UnlockXp,
    IReadOnlyList<string> Effects,
    string Source
);

public record Path2(
    string Name,
    string Description,
    Cost Cost,
    int UnlockXp,
    IReadOnlyList<string> Effects,
    string Source
);

public record Path3(
    string Name,
    string Description,
    Cost Cost,
    int UnlockXp,
    IReadOnlyList<string> Effects,
    string Source
);

public record Paths(
    IReadOnlyList<Path1> Path1,
    IReadOnlyList<Path2> Path2,
    IReadOnlyList<Path3> Path3,
    Paragon Paragon
);

public record Tower(
    string Id,
    string Name,
    string Description,
    string Type,
    Cost Cost,
    Stats Stats,
    int Footprint,
    string DefaultHotkey,
    Paths Paths
);

public record Stats(
    string Damage,
    string Pierce,
    string AttackSpeed,
    string Range,
    string Type
);

