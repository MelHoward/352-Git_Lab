using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest352
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a minimum and maximum value for the range the number will be drawn from");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a: {0}, b: {1}", a, b);


            Random rand = new Random();
            int randomNumber = rand.Next(a, b);

            bool correct = false;
            int guesses = 0;

            int input = Convert.ToInt32(Console.ReadLine());
            while (!correct)
            {
                if (input == randomNumber) { correct = true; guesses += 1; break; }
                else if (input < randomNumber) { Console.WriteLine("Higher "); guesses += 1; }
                else if (input > randomNumber) { Console.WriteLine("Lower "); guesses += 1; }
                input = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("You guessed {0} times before guessing correctly.", guesses);
        }
    }
}
