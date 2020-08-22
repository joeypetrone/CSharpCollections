using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CSharpCollections.FavoritePizzaToppings
{
    class FavoritePizzaToppings : ConsoleApp
    {
        public FavoritePizzaToppings()
        {
            Name = "Favorite Pizza Toppings";
        }
        public override void Run()
        {
            var json = File.ReadAllText("FavoritePizzaToppings/pizza.json");

            var pizzas = JsonSerializer.Deserialize<List<Pizza>>(json);

            var toppingsOrderedStringList = pizzas.Select(pizza => String.Join(", ", pizza.toppings.OrderBy(topping => topping)));

            var toppingsDictionary = new Dictionary<string, int>();

            foreach (var topping in toppingsOrderedStringList)
            {
                if (!toppingsDictionary.ContainsKey(topping))
                {
                    toppingsDictionary.Add(topping, 1);
                }
                else
                {
                    toppingsDictionary[topping]++;
                }
            }

            var topTwentyToppings = toppingsDictionary.OrderByDescending(toppings => toppings.Value).ToList().GetRange(0, 20);

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            foreach (var toppings in topTwentyToppings)
            {
                Console.WriteLine($"#{topTwentyToppings.IndexOf(toppings) + 1} Pizza Topping(s): {textInfo.ToTitleCase(toppings.Key)}\nOrder Count: {toppings.Value}\n");
            }

        }
    }
}
