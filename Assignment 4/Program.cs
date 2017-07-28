using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Abubakir Myrzaly
 * StudentID: 300931945
 * Date: July 23, 2017
 * Description: This is the driver class for my project
 * Version: 0.4 - Made some corrections with objects
 */

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            // creating objects
            GiantPlanet Neptune = new GiantPlanet("Neptune", 49000, Math.Pow(10, 27), "Ice");
            TerrestrialPlanet Earth = new TerrestrialPlanet("Earth", 12742, 5.972 * Math.Pow(10, 26), true);

            Console.WriteLine("Planets:");
            Console.WriteLine(Earth.ToString());
            Console.WriteLine(Neptune.ToString());

            waitForAnyKey();

            Console.WriteLine("\nGiant Planet");
            Console.WriteLine(Neptune.ToString());
            Neptune.RingCount = 0;
            Console.WriteLine("HasRings: {0}", Neptune.HasRings());

            Console.WriteLine("\nTerrestrial Planet");
            Console.WriteLine(Earth.ToString());
            Earth.Oxygen = true;
            Console.WriteLine("Habitable: {0}", Earth.Habitable());
            Earth.MoonCount = 1;
            Console.WriteLine("HasMoons: {0}", Earth.HasMoons());

        }

        static void waitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
