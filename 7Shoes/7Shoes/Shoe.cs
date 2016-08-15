using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Shoes
{
    enum Style
    {
        Sneakers,
        Loafers,
        Sandals,
        Flipflops,
        Wingtips,
        Clogs,
    }

    enum Color
    {
        Black,
        Brown,
        White,
        Red,
        Green,
        Orange,
    }

    class Shoe
    {
        public Style Style;
        public Color Color;
    }
}
