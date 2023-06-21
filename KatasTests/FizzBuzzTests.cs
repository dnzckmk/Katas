using Katas;

namespace FizzBuzzTests
{
    /// <summary>
    /// Test class of the FizzBuzz class.
    /// </summary>
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            this.fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void PrintNumbersShouldPrintNumbersFrom1To100()
        {
            var expected = string.Join(Environment.NewLine, Enumerable.Range(1, 100));

            var actual = this.fizzBuzz.PrintNumbers();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}