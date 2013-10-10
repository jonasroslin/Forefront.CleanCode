using System;

namespace Forefront.CleanCode.Objects
{
    public class GameData
    {
        public int NumberOfGames { get; set; }
        public int NumberOfTries { get; set; }
        public int NumberOfGlobalTries { get; set; }
        public int CurrentInputNumber { get; set; }
        public int MagicNumber { get; set; }

        public GameData()
        {
            NumberOfGames = 0;
            NumberOfGlobalTries = 0;
            NumberOfTries = 0;
        }

        public void GenerateNewRandonNumber()
        {
            var random = new Random();
            MagicNumber = random.Next(1, 10);
        }

        public float GetAverageNumbersOfTries()
        {
            return NumberOfGlobalTries / (float)NumberOfGames;
        }

        public void CommitANewTry()
        {
            NumberOfTries++;
            NumberOfGlobalTries++;// = NumberOfGlobalTries + NumberOfTries;
        }
    }
}