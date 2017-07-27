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
 * Version: 0.3 - Created the TerrestrialPlanet object
 */

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet Mars = new GiantPlanet("Mars", 2500, 7500, "Gas");
            Console.WriteLine(Mars);

            TerrestrialPlanet Moon = new TerrestrialPlanet("Moon", 1250, 3000, true);
            Console.WriteLine(Moon);
        }

        static void waitForAnyKey()
        {

        }
    }
}
