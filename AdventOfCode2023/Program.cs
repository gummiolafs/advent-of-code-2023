using AdventOfCode2023.Data;
using AdventOfCode2023.Models;
using AdventOfCode2023.Solutions;

Console.WriteLine("--- Day 1: Trebuchet?! ---");
var day1TrebuchetLines = Day1TrebuchetData.GetLines(Day1TrebuchetData.InputData);
Console.WriteLine($"- Numeric Only Calibration Number: {Day1Trebuchet.ParseCalibrationValue(day1TrebuchetLines, false)}");
Console.WriteLine($"- Numeric and Text Number: {Day1Trebuchet.ParseCalibrationValue(day1TrebuchetLines, true)}");
Console.WriteLine();

Console.WriteLine("--- Day 2: Cube Conundrum ---");
var day2CubeConundrumGames = Day2CubeConundrumData.GetGames(Day2CubeConundrumData.InputData).ToList();
var day2BagContents = new Day2CubeConundrumModels.Cubes(12, 13, 14);
Console.WriteLine($"- Sum of possible games: {Day2CubeConundrum.SumPossibleGames(day2CubeConundrumGames,day2BagContents)}");
Console.WriteLine($"- Power of fewest cubes: {Day2CubeConundrum.SumOfThePowerOfFewestCubes(day2CubeConundrumGames)}");

Console.WriteLine("--- Day 3: Gear Ratios ---");
var day3GearRatiosData = Day3GearRatiosData.GetSchematic(Day3GearRatiosData.InputData);
Console.WriteLine($"- Engine part number sum: {Day3GearRatios.GetPartNumberSum(day3GearRatiosData)}");
Console.WriteLine($"- Gear ratio sum: {Day3GearRatios.GetGearRatioSum(day3GearRatiosData)}");

Console.WriteLine("--- Day 4: Scratchcards ---");
var day4ScratchcardsData = Day4ScratchcardsData.GetCards(Day4ScratchcardsData.InputData).ToList();
Console.WriteLine($"- Total winning points: {Day4Scratchcards.GetTotalWinningPoints(day4ScratchcardsData)}");
Console.WriteLine($"- Total cards revised rules: {Day4Scratchcards.GetScratchCardCount(day4ScratchcardsData)}");