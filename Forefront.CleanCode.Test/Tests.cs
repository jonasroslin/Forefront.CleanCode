using Forefront.CleanCode.Objects;
using NUnit.Framework;

namespace Forefront.CleanCode.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly GameData _gameData;

        public Tests()
        {
            _gameData = new GameData();
        }
        
        [Test]
        public void Test()
        {
            Assert.That(true);
        }

        [Test]
        public void New_random_number_should_be_generated()
        {
            _gameData.GenerateNewRandonNumber();
            Assert.That(_gameData.MagicNumber > 0 && _gameData.MagicNumber <= 10);
        }

        [Test]
        public void Should_calculate_average_number_of_tries()
        {
            _gameData.NumberOfGlobalTries = 30;
            _gameData.NumberOfGames = 3;
            var avgCorrectValue = _gameData.GetAvgCorrectValue();
            Assert.AreEqual(avgCorrectValue, 10);
        }

        [Test]
        public void Should_Increase_global_tries_by_last_game_result()
        {
            _gameData.NumberOfGlobalTries = 10;
            _gameData.NumberOfTries = 2;
            _gameData.EnterANewTry();
            Assert.AreEqual(_gameData.NumberOfGlobalTries, 12);
        }

        [Test]
        public void Let_user_guess()
        {
            
        }
    }
}
