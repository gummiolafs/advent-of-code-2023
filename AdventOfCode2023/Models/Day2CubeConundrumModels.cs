namespace AdventOfCode2023.Models;

public static class Day2CubeConundrumModels
{
    public record Game(int Number, IEnumerable<Cubes> Draws);
    public record Cubes(int Red, int Green, int Blue);
}