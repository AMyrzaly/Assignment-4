using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * StudentID: 300931945
 * Date: July 24, 2017
 * Description: This is an Interface that defines a Habitable Property that
 * must be implemented in any class that subscribes to it.
 * Version: 0.1 - created the IHabitable interface
 */

namespace Assignment_4
{
    public interface IHabitable
    {
        bool Habitable { get; set; }
    }
}