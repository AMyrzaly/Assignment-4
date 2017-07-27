using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * StudentID: 300931945
 * Date: July 24, 2017
 * Description: This is the TerrestrialPlanet class which is subclass of derive class. 
 * The class will also implement both the IHasMoons and IHasRings interfaces.
 * Version: 0.4 - Correct error with interfaces
 */

namespace Assignment_4
{
    public class TerrestrialPlanet : Planet , IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES

        private bool _oxygen;

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PRIVATE METHODS

        public bool HasMoons()
        {
            return MoonCount > 0;
        }

        public bool Habitable()
        {
            return _oxygen;
        }

        // PUBLIC METHODS

    }
}