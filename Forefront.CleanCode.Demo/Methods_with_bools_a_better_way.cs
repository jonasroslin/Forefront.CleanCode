using FluentAssertions;
using NUnit.Framework;

namespace Forefront.CleanCode.Demo
{
    [TestFixture]
    public class Methods_with_bools_a_better_way
    {
        [Test]
        public void Calculate_with_addition()
        {
            var result = CalculateWithAddition(5, 10);
            result.Should().Be(15);
        }

        [Test]
        public void Calculate_with_subtraction()
        {
            var result = CalculateWithSubtraction(10, 5);
            result.Should().Be(5);
        }

        public static int CalculateWithAddition(int bar, int baz)
        {
            return bar + baz;
        }

        public static int CalculateWithSubtraction(int bar, int baz)
        {
            return bar - baz;
        }
    }
}