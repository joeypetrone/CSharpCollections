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

            var randomSquaredNumbersList = new List<int>();

            foreach (var number in randomNumbersList)
            {
                randomSquaredNumbersList.Add(number * number);
            }


            var combined = randomNumbersList.Select(number => new { RandomNumber = number, Squared = number * number });

            var bothNumberListsCombined = randomNumbersList.Zip
                (
                randomSquaredNumbersList,
                (randomNumber, randomSquaredNumber) => new
                {
                    RandomNumber = randomNumber, 
                    RandomSquaredNumber = randomSquaredNumber 
                });

            Console.WriteLine("");
            foreach (var numberPair in bothNumberListsCombined)
            {
                Console.WriteLine($"{numberPair.RandomSquaredNumber} is square root of {numberPair.RandomNumber}.");
                Console.WriteLine("");
            }

            randomSquaredNumbersList.RemoveAll(number => number % 2 != 0);

            foreach (var randomSquared in randomSquaredNumbersList)
            {
                Console.WriteLine($"{randomSquared} is even and thus was not removed.");
            }

        }
    }
}
