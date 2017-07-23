using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * Date: July 23, 2017
 * Description: This is the abstract class Planet which other subclasses will
 * derive from.
 * Version: 0.2 - Added the Public Properties
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

        // PUBLIC ABSTRACT METHODS
    }
}