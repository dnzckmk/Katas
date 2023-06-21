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

        [TestCase(1, 100, "Composite\r\nPrime\r\nPrime\r\n4\r\nPrime\r\n6\r\nPrime\r\n8\r\nComposite\r\n10\r\nPrime\r\n12\r\nPrime\r\n14\r\nComposite\r\n16\r\nPrime\r\n18\r\nPrime\r\n20\r\nComposite\r\n22\r\nPrime\r\n24\r\nComposite\r\n26\r\nComposite\r\n28\r\nPrime\r\n30\r\nPrime\r\n32\r\nComposite\r\n34\r\nComposite\r\n36\r\nPrime\r\n38\r\nComposite\r\n40\r\nPrime\r\n42\r\nPrime\r\n44\r\nComposite\r\n46\r\nPrime\r\n48\r\nComposite\r\n50\r\nComposite\r\n52\r\nPrime\r\n54\r\nComposite\r\n56\r\nComposite\r\n58\r\nPrime\r\n60\r\nPrime\r\n62\r\nComposite\r\n64\r\nComposite\r\n66\r\nPrime\r\n68\r\nComposite\r\n70\r\nPrime\r\n72\r\nPrime\r\n74\r\nComposite\r\n76\r\nComposite\r\n78\r\nPrime\r\n80\r\nComposite\r\n82\r\nPrime\r\n84\r\nComposite\r\n86\r\nComposite\r\n88\r\nPrime\r\n90\r\nComposite\r\n92\r\nComposite\r\n94\r\nComposite\r\n96\r\nPrime\r\n98\r\nComposite\r\n100")]
        [TestCase(5, 20, "Prime\r\n6\r\nPrime\r\n8\r\nComposite\r\n10\r\nPrime\r\n12\r\nPrime\r\n14\r\nComposite\r\n16\r\nPrime\r\n18\r\nPrime\r\n20")]
        public void PrintNumbersInRangeShouldPrintPrimeInsteadOfPrimeNumbersAndCompositeInsteadOfCompositeNumbers(int start, int end, string expected)
        {
            var actual = this.primeComposite.PrintNumbersInRange(start, end);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
