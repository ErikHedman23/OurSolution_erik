using MainProject_erik;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

namespace UnitTest_erik
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5, 10)] //10 is expected from 5 + 5
        [InlineData(3, 2, 5)]
        public void AddTest(int num1, int num2, int expected)
        {
            //Step 1: Arrange
            var helper = new Helper();

            //Step 2: Act

            var actual = helper.Add(num1, num2);

            //Step 3: Assert

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(5, 10, -5)]
        public void SubtractTest(double num1, double num2, double expected)
        {
            var helper = new Helper();

            var actual = helper.Subtract(num1, num2);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Seth", "Hello, Seth!")]
        [InlineData("John", "Hello, John!")]
        [InlineData("", "Hello!")]
        [InlineData(null, "Hello!")]
        public void GreetTest(string name, string expected)
        {
            var helper = new Helper();

            var actual = helper.Greeting(name);

            Assert.Equal(expected, actual);
        }
    }
}