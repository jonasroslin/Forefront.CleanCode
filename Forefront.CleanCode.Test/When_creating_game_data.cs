using FluentAssertions;
using Forefront.CleanCode.Objects;
using NUnit.Framework;

namespace Forefront.CleanCode.Tests
{
    [TestFixture]
    public class When_creating_game_data
    {
        private GameData _gameData;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _gameData = new GameData();
        }

        [Test]
        public void Number_of_games_should_be_zero()
        {
            _gameData.NumberOfGames.Should().Be(0);
        }

        [Test]
        public void Number_of_tries_should_be_zero()
        {
            _gameData.NumberOfTries.Should().Be(0);
        }
        
    }
}