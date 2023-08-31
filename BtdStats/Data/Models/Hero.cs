namespace BtdStats.Data.Models;

public record Level(
    int level,
    string description,
    int xp,
    Rounds rounds,
    IReadOnlyList<string> effects,
    string source
);

public record Hero(
    string id,
    string name,
    string description,
    IReadOnlyList<int> skinChange,
    IReadOnlyList<Skin> skins,
    HeroStats stats,
    Unlock unlock,
    string levelSpeed,
    IReadOnlyList<Level> levels
);

public record Rounds(
    string easy,
    string medium,
    string hard,
    string impoppable
);

public record Skin(
    string id,
    string name
);

public record Special(
    string name,
    string value
);

public record HeroStats(
    string damage,
    string pierce,
    string attackSpeed,
    string range,
    string type,
    IReadOnlyList<Special> special
);

public record Unlock(
    string how,
    string value
);

