using System;

namespace App18
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            double number = Convert.ToSingle(inputData);
            
            string message = string.Empty;
            bool check = number % 3 == 0 && number % 5 != 0;
            if (check)
            {
                message = "Fizz";
            }
            else if (number % 3 != 0 && number % 5 == 0)
            {
                message = "Buzz";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                message = "FizzBuzz";
            }
            else
            {
                message = number.ToString();
            }
            Console.WriteLine(message);
        }
    }
}
