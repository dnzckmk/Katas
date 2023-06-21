/*
### The FizzBuzz Kata
    - Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
      instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both
      three and five print "FizzBuzz".

#### Steps:
    Lets divide this into different steps so, we can easily write and test this.
    - Print numbers from 1 to 100
    - Print "Fizz" instead of number which is divisible by 3
    - Print "Buzz" instead of number which is divisible by 5
    - Print "FizzBuzz" instead of number which is divisible by both 3 and 5

#### Make more test for accept numbers and provide results
    - Create a method to accept single number
    - Create test to verify supplied number within the range 1 to 100
    - Create test to verify number and return result Fizz or Buzz or FizzBuzz per above criteria
*/
using System.Text;

namespace Katas
{
    /// <summary>
    /// FizzBuzz class.
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// Prints number between 1 and 100.
        /// Runs under FizzBuzz logic.
        /// </summary>
        /// <returns>Returns numbers from 1 to 100 with fizz buzz logic as a sting.</returns>
        public string PrintNumbers()
        {
            var output = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                output.AppendLine(GetFizzBuzz(i));
            }

            return output.ToString().TrimEnd();
        }

        /// <summary>
        /// If the number is a multiple of 3 get "Fizz", a multiple of 5 get "Buzz", multiple of both 3 and 5 get "FizzBuzz", else get number itself as a string value.
        /// </summary>
        /// <param name="number">Number to process.</param>
        /// <returns>Returns string value of the number it self if it is not a multiple of 3, 5 or 3 and 5 both. Otherwise it returns "Fizz", "Buzz" or "FizzBuzz" respectively. </returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws ArgumentOutOfRangeException if the given number is less than zero or bigger than 100.</exception>
        public string GetFizzBuzz(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be within the range of 1 to 100.");
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
