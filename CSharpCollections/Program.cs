using System;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomSquare = new RandomSquare.RandomSquare();
            var planetAndSpaceships = new PlanetsAndSpaceships.PlanetsAndSpaceships();
            var familyDictionary = new FamilyDictionary.FamilyDictionary();
            var stockPurchaseDictionary = new StockPurchaseDictionary.StockPurchaseDictionary();
            var anythingButCreed = new AnythingButCreed.AnythingButCreed();
            var favoritePizzaToppings = new FavoritePizzaToppings.FavoritePizzaToppings();

            var apps = new List<ConsoleApp> 
            { 
                randomSquare, 
                planetAndSpaceships, 
                familyDictionary, 
                stockPurchaseDictionary,
                anythingButCreed,
                favoritePizzaToppings
            };

            do
            {
                foreach(var app in apps)
                {
                    if (runConsoleApp(app.Name))
                    {
                        app.Run();
                    }
                }

            } while (loopProgram());

            bool runConsoleApp(string app)
            {
                Console.WriteLine($"Would you like to run {app}?");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() != "no" && userInput.ToLower() != "n")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool loopProgram()
            {
                Console.WriteLine("Do you want to run again?");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "no" || userInput.ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
