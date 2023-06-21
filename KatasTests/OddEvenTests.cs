using Katas;

namespace KatasTests
{
    /// <summary>
    /// OddEven test class.
    /// </summary>
    public class OddEvenTests
    {
        private OddEven oddEven;

        [SetUp]
        public void Setup()
        {
            this.oddEven = new OddEven();
        }

        [TestCase(1, 100, "Odd\r\nEven\r\n3\r\nEven\r\n5\r\nEven\r\n7\r\nEven\r\nOdd\r\nEven\r\n11\r\nEven\r\n13\r\nEven\r\nOdd\r\nEven\r\n17\r\nEven\r\n19\r\nEven\r\nOdd\r\nEven\r\n23\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n29\r\nEven\r\n31\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n37\r\nEven\r\nOdd\r\nEven\r\n41\r\nEven\r\n43\r\nEven\r\nOdd\r\nEven\r\n47\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n53\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n59\r\nEven\r\n61\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n67\r\nEven\r\nOdd\r\nEven\r\n71\r\nEven\r\n73\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n79\r\nEven\r\nOdd\r\nEven\r\n83\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n89\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\nOdd\r\nEven\r\n97\r\nEven\r\nOdd\r\nEven")]
        [TestCase(1, 10, "Odd\r\nEven\r\n3\r\nEven\r\n5\r\nEven\r\n7\r\nEven\r\nOdd\r\nEven")]
        [TestCase(11, 25, "11\r\nEven\r\n13\r\nEven\r\nOdd\r\nEven\r\n17\r\nEven\r\n19\r\nEven\r\nOdd\r\nEven\r\n23\r\nEven\r\nOdd")]
        public void PrintNumbersInRangeShouldReturnNumbersFromTheStartToEnd(int start, int end, string expected)
        {
            string actual = this.oddEven.PrintNumbersInRange(start, end);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(2)]
        [TestCase(40)]
        [TestCase(98)]
        public void EvenOddPrimeShouldReturnEvenForMultipleof2(int number)
        {
            var result = this.oddEven.EvenOddPrime(number);
            Assert.That(result, Is.EqualTo("Even"));
        }

        [TestCase(1)]
        [TestCase(25)]
        [TestCase(99)]
        public void EvenOddPrimeShouldReturnOddForNotEvenOrPrimeNumbers(int number)
        {
            var result = this.oddEven.EvenOddPrime(number);
            Assert.That(result, Is.EqualTo("Odd"));
        }

        [TestCase(3, "3")]
        [TestCase(11, "11")]
        [TestCase(97, "97")]
        public void EvenOddPrimeShouldReturnNumberAsStringForPrimeNumbers(int number, string expected)
        {
            var result = this.oddEven.EvenOddPrime(number);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}