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
            Console.WriteLine("I'm thinking of a number between 1 and 100");
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            int input = Console.Read();
            int i = 0;
            bool correct = false;

            while(!correct)
            {
                if(input == randomNumber) {
                    correct = true;
                    break;
                }
                else
                   Console.WriteLine("wrong");
                   i++;
                   input = Console.Read();
            }
            Console.WriteLine("You guessed ", i, "times before guessing correctly.");
        }
    }
}
