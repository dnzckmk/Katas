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

        public string PrintNumbers()
        {
            var output = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                output.AppendLine(i.ToString());
            }

            return output.ToString().TrimEnd();
        }

        public string GetFizzBuzz(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be within the range of 1 to 100.");
            }

            return number.ToString();
        }
    }
}
