using System;

namespace Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            Console.WriteLine("what is your favorite subject?");
            string favSubject = Console.ReadLine();
            
            switch (favSubject)
            {
                case "science":
                    Console.WriteLine("not science");
                    break;
                case "math":
                    Console.WriteLine("not math");
                    break;
                case "history":
                    Console.WriteLine("not history");
                    break;
                case "computer engineering":
                    Console.WriteLine("yes, that is my favorite!");
                    break;
                case "english":
                    Console.WriteLine("not english");
                    break;
                    default: Console.WriteLine("wrong!");
                    break;


            }

        }


    }
}
