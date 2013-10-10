using System;

namespace Forefront.CleanCode.Objects
{
    public class MagicNumberGame
    {
        private readonly GameData _gameData;
        private readonly IPrinter _printer;

        public MagicNumberGame()
        {
            _printer = new Printers.ConsolePrinter();
            _gameData = new GameData();
        }

        public void IncreaseTotalNumberOfGamesByOne()
        {
            _gameData.NumberOfGames++;
        }

        public void StartANewGame()
        {
            _gameData.GenerateNewRandonNumber();
            _gameData.NumberOfTries = 0;
        }

        public void PrintResult()
        {
            _printer.PrintLine("Correct after {0} times", _gameData.NumberOfTries);
            _printer.PrintLine("Correct number {0}", _gameData.MagicNumber);
            float avg = _gameData.GetAverageNumbersOfTries();
            _printer.PrintLine("Avg: {0}", avg);
        }

        public void LetTheUserGuessANumberUntilTheNumberIsCorrect()
        {
            var inputNumber = new int();
            while (inputNumber != _gameData.MagicNumber)
            {
                _printer.Print("Enter a number: ");
                inputNumber = ReadInputNumberFromUser();
                CheckTheResultOfInputNumberAndPrintResult(inputNumber);
                _gameData.CommitANewTry();
            }
        }

        public bool CheckIfUserWantsToPlayOneMoreTime()
        {
            _printer.Print("One more time? Y/N ");
            var line = Console.ReadLine();
            return line != null && line.ToLower() == "y";
        }

        private static int ReadInputNumberFromUser()
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