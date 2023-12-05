using AdventOfCode2023.Data;
using AdventOfCode2023.Solutions;

namespace Tests;

public class Day3GearRatiosTests
{
    [Fact]
    public void Part1Test()
    {
        // Arrange
        var testInput =
            """
            467..114..
            ...*......
            ..35..633.
            ......#...
            617*......
            .....+.58.
            ..592.....
            ......755.
            ...$.*....
            .664.598..
            """;

        // Act
        var actual = Day3GearRatios.GetPartNumberSum(Day3GearRatiosData.GetSchematic(testInput));

        // Assert
        Assert.Equal(4361, actual);
    }
    
    [Fact]
    public void Part2Test()
    {
        // Arrange
        var testInput =
            """
            467..114..
            ...*......
            ..35..633.
            ......#...
            617*......
            .....+.58.
            ..592.....
            ......755.
            ...$.*....
            .664.598..
            """;

        // Act
        var actual = Day3GearRatios.GetGearRatioSum(Day3GearRatiosData.GetSchematic(testInput));

        // Assert
        Assert.Equal(467835, actual);
    }
}