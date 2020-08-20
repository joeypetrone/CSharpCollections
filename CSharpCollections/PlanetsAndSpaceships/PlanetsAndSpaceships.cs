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

            //Spaceship Dictionary

            var spaceships = new Dictionary<string, List<string>>()
            {
                {
                    "Mercury", 
                    new List<string>() { "Mariner 10", "MESSENGER" }
                },
                {
                    "Venus",
                    new List<string>() { "Mariner 2", "Mariner 5", "Mariner 10", "Galileo", "Magellan", "Cassini", "MESSENGER" }
                },
                {
                    "Earth",
                    new List<string>() { "Mariner 10", "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2" }
                },
                {
                    "Mars",
                    new List<string>() { "Mariner 4", "Mariner 6", "Mariner 7", "Mariner 9", "Viking 1", "Viking 2", "Odyssey", "Curiosity", "InSight" }
                },
                {
                    "Jupiter",
                    new List<string>() { "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2", "Galileo", "Cassini", "Juno" }
                },
                {
                    "Saturn",
                    new List<string>() { "Pioneer 11", "Voyager 1", "Voyager 2", "Cassini" }
                },
                {
                    "Uranus",
                    new List<string>() { "Voyager 2" }
                },                
                {
                    "Neptune",
                    new List<string>() { "Voyager 2" }
                }
            };

            foreach (var planet in spaceships)
            {
                Console.WriteLine($"{planet.Key}:");
                foreach ( var spacechip in planet.Value)
                {
                    Console.WriteLine($"    {spacechip}");
                }
            }


        }
    }
}
