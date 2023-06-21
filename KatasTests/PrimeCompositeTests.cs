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

        [TestCase(1, 100, "1\r\nPrime\r\nPrime\r\n4\r\nPrime\r\n6\r\nPrime\r\n8\r\n9\r\n10\r\nPrime\r\n12\r\nPrime\r\n14\r\n15\r\n16\r\nPrime\r\n18\r\nPrime\r\n20\r\n21\r\n22\r\nPrime\r\n24\r\n25\r\n26\r\n27\r\n28\r\nPrime\r\n30\r\nPrime\r\n32\r\n33\r\n34\r\n35\r\n36\r\nPrime\r\n38\r\n39\r\n40\r\nPrime\r\n42\r\nPrime\r\n44\r\n45\r\n46\r\nPrime\r\n48\r\n49\r\n50\r\n51\r\n52\r\nPrime\r\n54\r\n55\r\n56\r\n57\r\n58\r\nPrime\r\n60\r\nPrime\r\n62\r\n63\r\n64\r\n65\r\n66\r\nPrime\r\n68\r\n69\r\n70\r\nPrime\r\n72\r\nPrime\r\n74\r\n75\r\n76\r\n77\r\n78\r\nPrime\r\n80\r\n81\r\n82\r\nPrime\r\n84\r\n85\r\n86\r\n87\r\n88\r\nPrime\r\n90\r\n91\r\n92\r\n93\r\n94\r\n95\r\n96\r\nPrime\r\n98\r\n99\r\n100")]
        public void PrintNumbersInRangeShouldPrintPrimeInsteadOfPrimeNumbers(int start, int end, string expected)
        {
            var actual = this.primeComposite.PrintNumbersInRange(start, end);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
