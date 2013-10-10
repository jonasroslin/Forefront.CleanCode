using FluentAssertions;
using Forefront.CleanCode.Objects;
using NUnit.Framework;

namespace Forefront.CleanCode.Tests
{
    [TestFixture]
    public class When_using_game_data_to_commit_a_new_try
    {
        private GameData _gameData;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _gameData = new GameData();
            _gameData.CommitANewTry();
        }

        [Test]
        public void Number_of_tries_should_be_increased_by_one()
        {
            _gameData.NumberOfTries.Should().Be(1);
        }
    }
}