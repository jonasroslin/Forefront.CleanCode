using System;

namespace Forefront.CleanCode.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int globalTimes = 0;
            int numberOfGames = 0;

            do
            {
                numberOfGames++;
                var magicNumber = CreateRandomMagicNumber();
                var numberOfTimes = LetUserGuessNumberUntilTheNumberIsCorrect(magicNumber);
                globalTimes = globalTimes + numberOfTimes;
                PrintResultToScreen(numberOfTimes, magicNumber, globalTimes, numberOfGames);

            } while (CheckIfUserWantsToPlayOneMoreTime());
        }

        private static int CreateRandomMagicNumber()
        {
            var random = new Random();
            var magicNumber = random.Next(1, 10);
            return magicNumber;
        }

        private static int LetUserGuessNumberUntilTheNumberIsCorrect(int magicNumber)
        {
            var numberOfTimes = 0;
            var inputNumber = new int();
            while (inputNumber != magicNumber)
            {
                Console.Write("Enter a number: ");
                inputNumber = ReadInputNumberFromUser();
                CheckTheResultOfInputNumberAndPrintResult(inputNumber, magicNumber);
                numberOfTimes++;
            }
            return numberOfTimes;
        }

        private static int ReadInputNumberFromUser()
        {
            var readLine = Console.ReadLine();
            int inputNumber = Convert.ToInt16(readLine);
            return inputNumber;
        }

        private static void CheckTheResultOfInputNumberAndPrintResult(int inputNumber, int magicNumber)
        {
            if (inputNumber != magicNumber)
                Console.WriteLine("Wrong number");
            if (inputNumber > magicNumber)
                Console.WriteLine("To high");
            if (inputNumber < magicNumber)
                Console.WriteLine("To low");
        }

        private static void PrintResultToScreen(int numberOfTimes, int magicNumber, int globalTimes, int numberOfGames)
        {
            Console.WriteLine("Correct after {0} times", numberOfTimes);
            Console.WriteLine("Correct number {0}", magicNumber);
            Console.WriteLine("Avg: {0}", globalTimes/numberOfGames);
        }

        private static void PrintResultToScreen(GameInformationModel gameInformationModel)
        {
            Console.WriteLine("Correct after {0} times", gameInformationModel.NumberOfTimes);
            Console.WriteLine("Correct number {0}", gameInformationModel.MagicNumber);
            Console.WriteLine("Avg: {0}", gameInformationModel.GlobalTimes / gameInformationModel.NumberOfGames);
        }

        private static bool CheckIfUserWantsToPlayOneMoreTime()
        {
            Console.WriteLine("One more time? Y/N");
            var line = Console.ReadLine();
            return line.ToLower() == "y";
        }
    }
}
