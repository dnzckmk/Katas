using Katas;

namespace KatasTests
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

        [TestCase(0)]
        [TestCase(101)]
        public void GetFizzBuzzShouldThrowIndexOutOfRangeExceptionIfNumberIsLessThan1OrBiggerThan100(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.fizzBuzz.GetFizzBuzz(number));
        }

        [TestCase(3)]
        [TestCase(27)]
        [TestCase(99)]
        public void GetFizzBuzzShouldReturnFizzForMultipleOf3(int number)
        {
            var result = this.fizzBuzz.GetFizzBuzz(number);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(100)]
        public void GetFizzBuzzShouldReturnBuzzForMultipleOf5(int number)
        {
            var result = this.fizzBuzz.GetFizzBuzz(number);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(90)]
        public void GetFizzBuzzShouldReturnFizzBuzzForMultipleOf3And5(int number)
        {
            var result = this.fizzBuzz.GetFizzBuzz(number);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [TestCase(1, "1")]
        [TestCase(22, "22")]
        [TestCase(98, "98")]
        public void GetFizzBuzzShouldReturnNumberAsStringForOtherNumbers(int number, string expected)
        {
            var result = this.fizzBuzz.GetFizzBuzz(number);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}