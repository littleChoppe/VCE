using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumenExtension
{
    static class SuperSolierSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            return ("I broke through a wall of " + wallDensity + " density.");
        }
    }
}
