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
            var expected = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n46\r\n47\r\nFizz\r\n49\r\nBuzz\r\nFizz\r\n52\r\n53\r\nFizz\r\nBuzz\r\n56\r\nFizz\r\n58\r\n59\r\nFizzBuzz\r\n61\r\n62\r\nFizz\r\n64\r\nBuzz\r\nFizz\r\n67\r\n68\r\nFizz\r\nBuzz\r\n71\r\nFizz\r\n73\r\n74\r\nFizzBuzz\r\n76\r\n77\r\nFizz\r\n79\r\nBuzz\r\nFizz\r\n82\r\n83\r\nFizz\r\nBuzz\r\n86\r\nFizz\r\n88\r\n89\r\nFizzBuzz\r\n91\r\n92\r\nFizz\r\n94\r\nBuzz\r\nFizz\r\n97\r\n98\r\nFizz\r\nBuzz";

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