using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * StudentID: 300931945
 * Date: July 23, 2017
 * Description: This is the GiantPlanet class which is subclass of derive class. 
 * The class will also implement both the IHasMoons and IHasRings interfaces.
 * Version: 0.6 - Correct error with interfaces
 */

namespace Assignment_4
{
    public class GiantPlanet : Planet ,IHasMoons , IHasRings
    {
        // PRIVATE INSTANCE VARIABLES

        private string _type;

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name,diameter,mass)
        {
            this._type = type;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS

        public bool HasMoons()
        {
            return MoonCount > 0;
        }

        public bool HasRings()
        {
            return RingCount > 0;
        }
    }
}