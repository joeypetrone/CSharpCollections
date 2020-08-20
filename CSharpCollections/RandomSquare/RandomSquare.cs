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

            var randomNumberList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                randomNumberList.Add(random.Next(1, 50));
            }

            var randomSquaredNumberList = new List<int>();

            foreach (var number in randomNumberList)
            {
                randomSquaredNumberList.Add(number * number);
            }

            var bothNumberListsCombined = randomNumberList.Zip
                (
                randomSquaredNumberList,
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

            randomSquaredNumberList.RemoveAll(number => number % 2 != 0);

            foreach (var randomSquared in randomSquaredNumberList)
            {
                Console.WriteLine($"{randomSquared} is even and thus was not removed.");
            }

        }
    }
}
