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
            List<string> planetsList = new List<string>() { "Mercury", "Mars" };

            planetsList.Add("Jupiter");
            planetsList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetsList.AddRange(lastTwoPlanets);

            planetsList.Insert(1, "Venus"); // Insert at index 1

            planetsList.Insert(2, "Earth"); // Insert at index 2

            planetsList.Add("Pluto");

            var rockyPlanets = planetsList.GetRange(0, 4);

            planetsList.ForEach(Console.WriteLine);

            Console.WriteLine("Rocky Planets:");

            rockyPlanets.ForEach(Console.WriteLine);

            planetsList.Remove("Pluto");

            //Spaceship Dictionary

            var spaceshipsDictionary = new Dictionary<string, List<string>>()
            {
                {
                    "Mariner 10",
                    new List<string>() { "Mercury", "Venus" , "Earth" }
                },
                {
                    "MESSENGER",
                    new List<string>() { "Mercury", "Venus" }
                },
                {
                    "Galileo",
                    new List<string>() { "Venus", "Jupiter" }
                },
                {
                    "Cassini",
                    new List<string>() { "Venus", "Jupiter", "Saturn" }
                },
                {
                    "Pioneer 10",
                    new List<string>() { "Earth", "Jupiter" }
                },
                {
                    "Pioneer 11",
                    new List<string>() { "Earth", "Jupiter", "Saturn" }
                },
                {
                    "Voyager 1",
                    new List<string>() { "Earth", "Jupiter", "Saturn" }
                },
                {
                    "Voyager 2",
                    new List<string>() { "Earth", "Jupiter", "Saturn", "Uranus", "Neptune" }
                },
                {
                    "Odyssey",
                    new List<string>() { "Mars" }
                },
                {
                    "Curiosity",
                    new List<string>() { "Mars" }
                },
                {
                    "InSight",
                    new List<string>() { "Mars" }
                },
            };

            foreach (var planet in planetsList)
            {
                var planetSpaceships = new List<string>();
                
                foreach (var spaceship in spaceshipsDictionary)
                {
                    if (spaceship.Value.Contains(planet))
                    {
                        planetSpaceships.Add(spaceship.Key);
                    }
                }

                var spaceshipList = string.Join(", ", planetSpaceships);

                Console.WriteLine($"{planet}: {spaceshipList}");
            }

            // Spaceships that visited each planet (DATA)
            //{
            //    "Mercury", 
            //    new List<string>() { "Mariner 10", "MESSENGER" }
            //},
            //{
            //    "Venus",
            //    new List<string>() { "Mariner 2", "Mariner 5", "Mariner 10", "Galileo", "Magellan", "Cassini", "MESSENGER" }
            //},
            //{
            //    "Earth",
            //    new List<string>() { "Mariner 10", "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2" }
            //},
            //{
            //    "Mars",
            //    new List<string>() { "Mariner 4", "Mariner 6", "Mariner 7", "Mariner 9", "Viking 1", "Viking 2", "Odyssey", "Curiosity", "InSight" }
            //},
            //{
            //    "Jupiter",
            //    new List<string>() { "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2", "Galileo", "Cassini", "Juno" }
            //},
            //{
            //    "Saturn",
            //    new List<string>() { "Pioneer 11", "Voyager 1", "Voyager 2", "Cassini" }
            //},
            //{
            //    "Uranus",
            //    new List<string>() { "Voyager 2" }
            //},                
            //{
            //    "Neptune",
            //    new List<string>() { "Voyager 2" }
            //}

        }
    }
}
