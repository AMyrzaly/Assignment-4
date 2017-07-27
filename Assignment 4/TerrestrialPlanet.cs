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
 * Version: 0.3 - Added the public properties
 */

namespace Assignment_4
{
    public class TerrestrialPlanet : Planet , IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES

        private bool _oxygen;

        // PUBLIC PROPERTIES

        public bool HasMoons
        {
            get
            {
                if (MoonCount > 0)
                {
                    return true;
                }
                else return false;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Habitable
        {
            get
            {
                if (_oxygen == 0)
                {
                    return true;
                }
                else return false;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

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