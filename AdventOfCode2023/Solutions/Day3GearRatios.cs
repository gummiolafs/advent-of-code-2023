using AdventOfCode2023.Models;

namespace AdventOfCode2023.Solutions;

public static class Day3GearRatios
{
    public static int GetPartNumberSum(Day3GearRatiosModels.EngineSchematic engineSchematic)
    {
        var numbers = engineSchematic.Numbers.ToList();

        return engineSchematic.Symbols
            .Select(s => PopAdjacentNumbers(s.X, s.Y, numbers).Sum())
            .Sum();
    }
    
    public static int GetGearRatioSum(Day3GearRatiosModels.EngineSchematic engineSchematic)
        => engineSchematic.Symbols
            .Where(s => s.Symbol == '*')
            .Select(s => engineSchematic.Numbers.Where(n => IsAdjacent(s.X, s.Y, n.XStart, n.XEnd, n.Y)))
            .Where(n => n.Count() > 1)
            .Sum(n => n.Aggregate(1, (a, v) => a * v.Value));

    private static IEnumerable<int> PopAdjacentNumbers(int x, int y, List<Day3GearRatiosModels.Number> numbers)
    {
        var results = new List<Day3GearRatiosModels.Number>();
        
        for (var i = 0; i < numbers.Count; i++)
        {
            if (IsAdjacent(x, y, numbers[i].XStart, numbers[i].XEnd, numbers[i].Y))
            {
                results.Add(numbers[i]);
                numbers.RemoveAt(i);
                i--;
            }
        }

        return results.Select(n => n.Value);
    }

    private static bool IsAdjacent(int symbolX, int symbolY, int numberStartX, int numberEndX, int numberY)
        => numberY >= symbolY - 1 && numberY <= symbolY + 1 && numberStartX - 1 <= symbolX && numberEndX + 1 > symbolX;
}