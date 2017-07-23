using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * Date: July 23, 2017
 * Description: This is the abstract class Planet which other subclasses will
 * derive from.
 * Version: 0.3 - Added the ToString to the Planet abstract class
 */

namespace Assignment_4
{
    public abstract class Planet
    {
        // PRIVATE FIELDS (INSTANCE VARIABLES)

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES

        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }

        // CONSTRUCTORS

        public Planet(string name, double diameter, double mass)
        {
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;
        }

        // PUBLIC METHODS

        public override string ToString()
        {
            return string.Format("Name: {0}, diameter: {1}, Mass: {2}", Name,Diameter,Mass);
        }
    }
}