using Katas;

namespace KatasTests
{
    public class OddEvenTests
    {
        private OddEven oddEven;

        [SetUp]
        public void Setup()
        {
            this.oddEven = new OddEven();
        }

        [TestCase(1, 100)]
        public void PrintNumbersInRangeShouldReturnNumbersFrom1To100(int start, int end)
        {
            var expected = string.Join(Environment.NewLine, Enumerable.Range(1, 100));

            string actual = this.oddEven.PrintNumbersInRange(1, 100);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
