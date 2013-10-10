using System;

namespace Forefront.CleanCode.Objects
{
    public class MagicNumberGame
    {
        private readonly GameData _gameData;
        private readonly IPrint _printer;

        public MagicNumberGame()
        {
            _printer = new Writer.Console();
            _gameData = new GameData();
        }

        public void IncreaseTotalNumberOfGamesByOne()
        {
            _gameData.NumberOfGlobalTries = _gameData.NumberOfGlobalTries + _gameData.NumberOfTries;
        }

        public void StartANewGame()
        {
            _gameData.GenerateNewRandonNumber();
            _gameData.NumberOfGames++;
            _gameData.NumberOfTries = 0;
        }

        public void PrintResult()
        {
            _printer.PrintLine(string.Format("Correct after {0} times", _gameData.NumberOfTries));
            _printer.PrintLine(string.Format("Correct number {0}", _gameData.MagicNumber));
            float avg = _gameData.GetAvgCorrectValue();
            _printer.PrintLine(string.Format("Avg: {0}", avg));
        }

        public void LetTheUserGuessANumberUntilTheNumberIsCorrect()
        {
            var inputNumber = new int();
            while (inputNumber != _gameData.MagicNumber)
            {
                _printer.Print("Enter a number: ");
                inputNumber = ReadInputNumberFromUser();
                CheckTheResultOfInputNumberAndPrintResult(inputNumber);
                _gameData.NumberOfTries++;
            }
        }

        public bool CheckIfUserWantsToPlayOneMoreTime()
        {
            _printer.Print("One more time? Y/N ");
            var line = Console.ReadLine();
            return line != null && line.ToLower() == "y";
        }

        public void AddTotalNumberOfGames()
        {
            _gameData.EnterANewTry();
        }

        private int ReadInputNumberFromUser()
        {
            var readLine = Console.ReadLine();
            int inputNumber = Convert.ToInt16(readLine);
            return inputNumber;
        }

        private void CheckTheResultOfInputNumberAndPrintResult(int inputNumber)
        {
            if (inputNumber != _gameData.MagicNumber)
                _printer.PrintLine("Wrong number");
            if (inputNumber > _gameData.MagicNumber)
                _printer.PrintLine("To high");
            if (inputNumber < _gameData.MagicNumber)
                _printer.PrintLine("To low");
        }
    }
}