using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCollections.RandomSquare
{
    class RandomSquare : ConsoleApp
    {
        public RandomSquare()   
        {
            Name = "Random Square";
        }
        public override void Run()
        {
            Random random = new Random();

            var randomNumbersList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                randomNumbersList.Add(random.Next(1, 51));
            }

            var combined = randomNumbersList.Select(number => new { RandomNumber = number, Squared = number * number }).ToList();

            foreach (var pair in combined)
            {
                Console.WriteLine($"\n{pair.Squared} is square root of {pair.RandomNumber}.");

                if (pair.Squared % 2 == 0)
                {
                    Console.WriteLine($"{pair.Squared} is even and thus will not removed.");
                }
                else
                {
                    Console.WriteLine($"{pair.Squared} is odd and will be removed.");
                }
            }

            combined.RemoveAll(number => number.Squared % 2 != 0);
            Console.WriteLine("\nEven Number Data:");
            combined.ForEach(Console.WriteLine);
        }
    }
}
