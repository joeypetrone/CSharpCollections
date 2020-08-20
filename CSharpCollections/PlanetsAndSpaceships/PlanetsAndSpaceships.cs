using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCollections.PlanetsAndSpaceships
{
    class PlanetsAndSpaceships : ConsoleApp
    {
        public PlanetsAndSpaceships()
        {
            Name = "Planets And Spaceships";
        }
        public override void Run()
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus");

            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.ForEach(Console.WriteLine);

            Console.WriteLine("Rocky Planets:");

            rockyPlanets.ForEach(Console.WriteLine);

            planetList.Remove("Pluto");
        }
    }
}
