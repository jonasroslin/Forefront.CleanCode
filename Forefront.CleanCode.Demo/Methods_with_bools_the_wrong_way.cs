using FluentAssertions;
using NUnit.Framework;

namespace Forefront.CleanCode.Demo
{
    [TestFixture]
    public class Methods_with_bools_the_wrong_way
    {
        [Test]
        public void Calculate_with_addition()
        {
            var result = Calculate(5, 10, true);
            result.Should().Be(15);
        }

        [Test]
        public void Calculate_with_subtraction()
        {
            var result = Calculate(10, 5, false);
            result.Should().Be(5);
        }

        public static int Calculate(int bar, int baz, bool useAddition)
        {
            int result;
            if (useAddition)
            {
                result = bar + baz;
            }
            else
            {
                result = bar - baz;
            }

            return result;
        }
    }


}
