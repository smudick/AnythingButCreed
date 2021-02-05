using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var allSongs = new List<Song>()
            {
                new Song("Creed", "Arms Wide Open"),
                new Song("Creed", "Can You Take Me Higher"),
                new Song("Creed", "Grunting Noises"),
                new Song("Wu Tang Clan", "C.R.E.A.M."),
                new Song("Sam Cooke", "Bring It On Home To Me"),
                new Song("Stevie Wonder", "Superstition"),
                new Song("Killers", "Mr. Brightside"),
                new Song("Kendrick Lamar", "Swimming Pools"),
                new Song("Punch Brothers", "Familiarity"),
                new Song("Local Natives", "Sun Hands"),
                new Song("Chopin", "One of those piano songs"),
                new Song("Not Creed", "Arms Respectfully Closed"),

            };
            var goodSongs = allSongs.Where(song => song.Artist != "Creed");

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");

            }
        }
    }
}
