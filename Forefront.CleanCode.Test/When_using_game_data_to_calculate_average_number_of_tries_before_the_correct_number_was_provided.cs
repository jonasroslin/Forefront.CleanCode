using FluentAssertions;
using Forefront.CleanCode.Objects;
using NUnit.Framework;

namespace Forefront.CleanCode.Tests
{
    [TestFixture]
    public class When_using_game_data_to_calculate_average_number_of_tries_before_the_correct_number_was_provided
    {
        private GameData _gameData;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _gameData = new GameData {NumberOfGlobalTries = 10, NumberOfGames = 5};
        }

        [Test]
        public void Average_number_should_be_calculuted_correctly()
        {
            _gameData.GetAverageNumbersOfTries().Should().Be(2);
        }
    }
}