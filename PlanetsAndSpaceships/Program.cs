using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            var lastTwo = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastTwo);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            var rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            var Mercury = new List<string> { "Mariner 10", "MESSENGER", "BepiColombo", "Mercury Planetary Orbiter", "Mio" };
            var Venus = new List<string> { "Tyazhely Sputnik", "Venera 1", "Mariner 1", "Sputnik 19", "Sputnik 20", "Sputnik 21", "Mariner 2" };
            var Earth = new List<string> { "Mariner 10", "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2" };
            var Mars = new List<string> { "Mars 1M No. 1", "Mars 1m No. 2", "Mars 1962A", "Mars 1962B" };
            var Jupiter = new List<string> { "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2", "Ulysses", "Galileo Orbiter" };
            var Saturn = new List<string> { "Pioneer 11", "Voyager 1", "Voyager 2", "Cassini" };
            var Uranus = new List<string> { "Voyager 2" };
            var Neptune = new List<string> { "Voyager 2", "IHP-2" };

            var planetaryProbes = new Dictionary<string, List<string>>();
            planetaryProbes.Add("Mercury", Mercury);
            planetaryProbes.Add("Venus", Venus);
            planetaryProbes.Add("Earth", Earth);
            planetaryProbes.Add("Mars", Mars);
            planetaryProbes.Add("Jupiter", Jupiter);
            planetaryProbes.Add("Saturn", Saturn);
            planetaryProbes.Add("Uranus", Uranus);
            planetaryProbes.Add("Neptune", Neptune);

            planetList.ForEach((planet) =>
            {
                Console.WriteLine(                 planet);
                Console.WriteLine("====================================");
                foreach(var item in planetaryProbes)
                {
                    if (item.Key == planet)
                    {
                        item.Value.ForEach((probe) => Console.WriteLine(probe));
                    }
                }
                Console.WriteLine("\n");
            });
        }
    }
}
