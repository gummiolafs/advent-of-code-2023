using AdventOfCode2023.Models;

namespace AdventOfCode2023.Solutions;

public static class Day4Scratchcards
{
    public static int GetTotalWinningPoints(IEnumerable<Day4ScratchcardsModels.Card> cards)
        => cards
            .Select(CalculateWins)
            .Sum(w => w == 0 ? 0 : Convert.ToInt32(Math.Pow(2, w - 1)));

    public static int GetScratchCardCount(IEnumerable<Day4ScratchcardsModels.Card> cards)
    {
        var cardArray = cards.ToArray();
        var cardCount = Enumerable.Repeat(1, cardArray.Length).ToArray();

        for (var i = 0; i < cardArray.Length; i++)
        {
            var wins = CalculateWins(cardArray[i]);
            for (var y = i + 1; y <= i + wins && y < cardArray.Length; y++)
                cardCount[y] += cardCount[i];
        }

        return cardCount.Sum();
    }

    private static int CalculateWins(Day4ScratchcardsModels.Card card)
        => card.CardNumbers.Count(n => card.WinningNumbers.Contains(n));
}