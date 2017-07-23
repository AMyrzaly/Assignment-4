using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * Date: July 23, 2017
 * Description: This is an Interface that defines a Moons Property that
 * must be implemented in any class that subscribes to it.
 * Version: 0.1 - Created IHasMoons interface
 */

namespace Assignment_4
{
    public interface IHasMoons
    {
        int Moons { get; set; }
    }
}