using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            bool runProgam = true;
            do
            {
                Console.WriteLine("Welcome to the Number Analyzer!");
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();

                //Get a number between 1 - 100
                Console.WriteLine($"Hi {name}! Please enter a number between 1 and 100.");
                int num = int.Parse(Console.ReadLine());
                if ((num % 2 == 0) && (num >= 2 && num < 25))
                {
                    Console.WriteLine($"{num} is an even number and less than 25, {name}.");
                }
                else if ((num % 2 == 0) && (num >= 25 && num <= 60))
                {
                    Console.WriteLine($"Even. {name}");
                }
                else if ((num % 2 == 0) && (num > 60))
                {
                    Console.WriteLine($"{num} is an even number and is more than 60, {name}.");
                }
                else if (num >= 101 && num < 2147483647)
                {
                    Console.WriteLine($"{num} is not between 1 - 100, please try again.");
                }
                //else if ((num % 1 == 0) && (num >60))
                //{
                //    Console.WriteLine($"{num} is an odd number, {name}");
                //}
                 else
                {
                    Console.WriteLine($"{num} is an odd number, {name}");
                }

                //Loop Continue y/n
                while (true)
                {
                    Console.WriteLine($"Want to do it again {name}? Enter Yes to continue, No to end.");
                    string loopCheck = Console.ReadLine();
                    if (loopCheck.ToLower() == "yes")
                    {
                        break; //continue program
                    }
                    else if (loopCheck.ToLower() == "no")
                    {
                        runProgam = false;
                        Console.WriteLine($"Goodbye {name} and have a Great Day!");
                        break; //end program
                    }
                    else
                    {
                        Console.WriteLine("Please type Yes or No only!");
                    }
                }
            } while (runProgam);
        }
    }
}
