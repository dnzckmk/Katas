/*
### The OddEven Kata
Write a program that prints numbers within specified range lets say 1 to 100.
If number is odd print 'Odd' instead of the number.
If number is even print 'Even' instead of number.
Else print number [hint - if number is Prime].

#### Steps :
Lets divide into following steps:
- Prints numbers from 1 to 100
- Print "Even" instead of number, if the number is even, means divisible by 2
- Print "Odd" instead of number, if the number is odd, means not divisible by 2 but not divisible by itself too [hint - it should not be Prime]
- Print number, if it does not meet above two conditions, means if number is Prime
- Make method to accept any number of range [currently  we have 1 to 100]
- Create a new method to check Odd/Even/Prime of a single supplied method
 */
using System.Text;

namespace Katas
{
    /// <summary>
    /// OddEven class.
    /// </summary>
    public class OddEven
    {
        /// <summary>
        /// Print numbers between given range. Uses EvenOddPrime logic.
        /// </summary>
        /// <param name="start">Start of the range.</param>
        /// <param name="end">End of the range.</param>
        /// <returns>Returns values as a string.</returns>
        public string PrintNumbersInRange(int start, int end)
        {
            var result = new StringBuilder();

            for (int number = start; number <= end; number++)
            {
                result.AppendLine(this.EvenOddPrime(number));
            }

            return result.ToString().TrimEnd();
        }

        /// <summary>
        /// Check if the number is even, odd or prime. 
        /// </summary>
        /// <param name="number">Integer number to check.</param>
        /// <returns>Returns "Even" for even number, "Odd" for odd values and number as a string if the value is a prime number.</returns>
        public string EvenOddPrime(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else if (!IsPrime(number))
            {
                return "Odd";
            }
            else
            {
                return number.ToString();
            }
        }

        /// <summary>
        /// Check if the number is prime.
        /// </summary>
        /// <param name="number">Integer number to check.</param>
        /// <returns>Returns true if the number is prime else returns false.</returns>
        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
