using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * Date: July 24, 2017
 * Description: This is the TerrestrialPlanet class which is subclass of derive class. 
 * The class will also implement both the IHasMoons and IHasRings interfaces.
 * Version: 0.2 - Added the private instance and constructor
 */

namespace Assignment_4
{
    public class TerrestrialPlanet : Planet , IHasMoons, IHasRings
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



        // PUBLIC METHODS

    }
}