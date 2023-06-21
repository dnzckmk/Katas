using Katas;

namespace KatasTests
{
    /// <summary>
    /// PrimeComposite tests.
    /// </summary>
    public class PrimeCompositeTests
    {
        private PrimeComposite primeComposite;

        [SetUp]
        public void Setup()
        {
            this.primeComposite = new PrimeComposite();
        }

        [TestCase(1, 100)]
        public void PrintNumbersInRangeShouldPrintNumbersFromStartToEnd(int start, int end)
        {
            var expected = string.Join(Environment.NewLine, Enumerable.Range(1, 100));
            var actual = this.primeComposite.PrintNumbersInRange(start, end);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
