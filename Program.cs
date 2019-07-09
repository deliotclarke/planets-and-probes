using System;
using System.Collections.Generic;

namespace PlanetsAndProbes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            var probeDestinations = new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>("Mercury", "Mariner 10"),
                new KeyValuePair<string, string>("Mercury", "Messenger"),
                new KeyValuePair<string, string>("Venus", "Sputnik 19"),
                new KeyValuePair<string, string>("Venus", "Mariner 2"),
                new KeyValuePair<string, string>("Venus", "Zond 1")
            };

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probeDesignation in probeDestinations)
                {
                    if (probeDesignation.Key == planet)
                    {
                        matchingProbes.Add(probeDesignation.Value);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
            }
        }
    }
}
