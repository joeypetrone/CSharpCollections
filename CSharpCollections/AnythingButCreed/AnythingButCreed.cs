using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCollections.AnythingButCreed
{
    class AnythingButCreed : ConsoleApp
    {
        public AnythingButCreed()
        {
            Name = "Anything But Creed";
        }
        public override void Run()
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>()
            {
                new Song("Creed", "Are You Ready?"),
                new Song("Creed", "With Arms Wide Open"),
                new Song("Creed", "My Own Prison"),
                new Song("Niravana", "Smells Like Teen Spirit"),
                new Song("Soundgarden", "Black Hole Sun"),
                new Song("Foo Fighters", "Everlong"),
                new Song("Green Day", "Basket Case"),
                new Song("Weezer", "Buddy Holly"),
                new Song("Beck", "Loser"),
                new Song("Blur", "Song 2"),
                new Song("Red Hot Chili Peppers", "Scar Tissue"),
                new Song("Live", "Lightning Crashes"),
            };

            goodSongs = allSongs.Where(song => song.Artist != "Creed").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }

        }
    }
}
