namespace Forefront.CleanCode.Objects
{
    class Program
    {
        static void Main()
        {
            var magicNumberGame = new MagicNumberGame();

            do
            {
                magicNumberGame.StartANewGame();
                magicNumberGame.LetTheUserGuessANumberUntilTheNumberIsCorrect();
                magicNumberGame.IncreaseTotalNumberOfGamesByOne();
                magicNumberGame.PrintResult();

            } while (magicNumberGame.CheckIfUserWantsToPlayOneMoreTime());
        }
    }
}
