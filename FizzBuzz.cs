using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        
        public static void IterateNumber()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(GetResult(i));
            }
        }
        
        public static string GetResult(int number)
        {
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

            return number.ToString();

        }
    }
}