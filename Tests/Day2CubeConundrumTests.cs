using AdventOfCode2023.Data;
using AdventOfCode2023.Models;
using AdventOfCode2023.Solutions;

namespace Tests;

public class Day2CubeConundrumTests
{
    [Fact]
    public void Part1Test()
    {
        // Arrange
        var testInput = """
                        Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
                        Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
                        Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
                        Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
                        Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green
                        """;

        var bagContents = new Day2CubeConundrumModels.Cubes(12,13,14);

        // Act
        var actual = Day2CubeConundrum.SumPossibleGames(Day2CubeConundrumData.GetGames(testInput), bagContents);

        // Assert
        Assert.Equal(8, actual);
    }
    
    [Fact]
    public void Part2Test()
    {
        // Arrange
        var testInput = """
                        Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
                        Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
                        Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
                        Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
                        Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green
                        """;

        // Act
        var actual = Day2CubeConundrum.SumOfThePowerOfFewestCubes(Day2CubeConundrumData.GetGames(testInput));

        // Assert
        Assert.Equal(2286, actual);
    }
}