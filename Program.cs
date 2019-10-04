using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");


             List<string> farPlanets = new List<string>(){"Neptune", "Pluto"};

             planetList.AddRange(farPlanets);

             planetList.Insert(1, "Venus");
             planetList.Insert(2, "Earth");

                 Console.WriteLine("----- Planets -----");
            foreach (string planet in planetList)
            {
                 Console.WriteLine(planet);
        }

        Console.WriteLine("----- Rocky Planets -----");

        List<string> rockyPlanets = planetList.GetRange(0, 4);

            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            planetList.Remove("Pluto");

            Console.WriteLine("----- Updated Planet List -----");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
    }
    // bingo
}
}

