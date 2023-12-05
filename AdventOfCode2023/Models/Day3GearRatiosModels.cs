namespace AdventOfCode2023.Models;

public static class Day3GearRatiosModels
{
    public record EngineSchematic(IEnumerable<Number> Numbers, IEnumerable<(char Symbol, int X, int Y)> Symbols);

    public record Number(int Value, int XStart, int XEnd, int Y); 
}