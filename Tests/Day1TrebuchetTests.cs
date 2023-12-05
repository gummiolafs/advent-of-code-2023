using AdventOfCode2023.Data;
using AdventOfCode2023.Solutions;

namespace Tests;

public class Day1TrebuchetTests
{
    [Fact]
    public void Part1Test()
    {
        // Arrange
        var testInput = """
                        1abc2
                        pqr3stu8vwx
                        a1b2c3d4e5f
                        treb7uchet
                        """;

        // Act
        var actual = Day1Trebuchet.ParseCalibrationValue(Day1TrebuchetData.GetLines(testInput), false);

        // Assert
        Assert.Equal(142, actual);
    }
    
    [Fact]
    public void Part2Test()
    {
        // Arrange
        var testInput = """
                        two1nine
                        eightwothree
                        abcone2threexyz
                        xtwone3four
                        4nineeightseven2
                        zoneight234
                        7pqrstsixteen
                        """;

        // Act
        var actual = Day1Trebuchet.ParseCalibrationValue(Day1TrebuchetData.GetLines(testInput), true);

        // Assert
        Assert.Equal(281, actual);
    }
}