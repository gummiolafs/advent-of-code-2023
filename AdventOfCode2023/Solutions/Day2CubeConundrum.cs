using AdventOfCode2023.Models;

namespace AdventOfCode2023.Solutions;

public static class Day2CubeConundrum
{
    public static int SumPossibleGames(IEnumerable<Day2CubeConundrumModels.Game> games,
        Day2CubeConundrumModels.Cubes bagContents)
        => games
            .Where(g => g.Draws.All(d =>
                d.Red <= bagContents.Red
                && d.Green <= bagContents.Green
                && d.Blue <= bagContents.Blue))
            .Sum(g => g.Number);

    public static int SumOfThePowerOfFewestCubes(IEnumerable<Day2CubeConundrumModels.Game> games)
        => games
            .Sum(g =>
                g.Draws.Max(d => d.Red)
                * g.Draws.Max(d => d.Green)
                * g.Draws.Max(d => d.Blue));
}