/*
### The PrimeFactor Kata (via [Uncle Bob](http://butunclebob.com/ArticleS.UncleBob.ThePrimeFactorsKata))

### The PrimeComposite Kata
    - Write a program that prints numbers within specified range lets say 1 to 100.
    - If number is ```prime``` print 'prime' instead of the number.
    - If number is ```composite``` but not ```even``` print 'composite' instead of number.
    - Else print number.
    - Reference(s)
        - [Prime numbers](https://en.wikipedia.org/wiki/Prime_number),
        - [Composite numbers](https://en.wikipedia.org/wiki/Composite_number),
        - [odd even](https://en.wikipedia.org/wiki/Parity_(mathematics))

### Steps
    - Prints numbers from 1 to 100.
    - Print "Prime" instead of number, if the number is prime, means ```number greater than 1 that has no positive divisors other than 1 and itself```.
    - Print "Composite" instead of number, if the number is composite, means ```number has at least one positive divisor other than one or the number itself. In other words, a composite number is any integer greater than one that is not a prime number``` but not a ```even number```.
    - An even number is ```an integer is even if it is 'evenly divisible' by two```.
    - Print number, if it does not meet above two conditions.
    - Make method to accept any number of range [currently  we have 1 to 100].
    - Create a new method to check Prime/Composite of a single supplied method.
 */
using System.Text;

namespace Katas
{
    /// <summary>
    /// Prime Composite class.
    /// </summary>
    public class PrimeComposite
    {
        public string PrintNumbersInRange(int start, int end)
        {
            var result = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                if (this.IsPrime(i))
                {
                    result.AppendLine("Prime");
                }
                else
                {
                    result.AppendLine(i.ToString());
                }
            }

            return result.ToString().TrimEnd();
        }

        /// <summary>
        /// Checks if the number is prime number.
        /// </summary>
        /// <param name="number">Integer number to check.</param>
        /// <returns>Returns true if the number is a prime number, else returns false.</returns>
        public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
