namespace AdventOfCode2023.Solutions;

public static class Day1Trebuchet
{
    private static readonly string[] Numbers =
        { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    public static int ParseCalibrationValue(IEnumerable<string> lines, bool allowText)
        => lines
            .Select(l
                => (l.Select((c, i) => l[i..])
                        .Select((c, i) =>
                            Numbers
                                .Select((v, y) => (v, y))
                                .Where(n => c[0] == n.Item2 + '0' ||
                                            (allowText && c.StartsWith(n.Item1, StringComparison.OrdinalIgnoreCase)))
                                .Select(v => (int?)v.Item2)
                                .FirstOrDefault())
                        .FirstOrDefault(n => n is not null) ?? 0,
                    l.Select((c, i) => l[..^i])
                        .Select((c, i) =>
                            Numbers
                                .Select((v, y) => (v, y))
                                .Where(n => c[^1] == n.Item2 + '0' ||
                                            (allowText && c.EndsWith(n.Item1, StringComparison.OrdinalIgnoreCase)))
                                .Select(v => (int?)v.Item2)
                                .FirstOrDefault())
                        .FirstOrDefault(n => n is not null) ?? 0))
            .Sum(l => l.Item1 * 10 + l.Item2);
}