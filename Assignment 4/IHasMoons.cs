using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * StudentID: 300931945
 * Date: July 23, 2017
 * Description: This is an Interface that defines a Moons Property that
 * must be implemented in any class that subscribes to it.
 * Version: 0.2 - Changed type int to bool and the name from "Moons" to "HasMoons"
 */

namespace Assignment_4
{
    public interface IHasMoons
    {
        bool HasMoons { get; set; }
    }
}