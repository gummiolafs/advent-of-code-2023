namespace AdventOfCode2023.Models;

public class Day4ScratchcardsModels
{
    public record Card(int CardNumber, IEnumerable<int> WinningNumbers, IEnumerable<int> CardNumbers);
}