using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.Schoes
{
    class Shoe
    {
        public Style Style { get; private set; }
        public string Color { get; private set; }

        public Shoe(Style style, string color) { 
            Style = style;
            Color = color;
        }

        public string Description { get { return $"A {Color} {Style}"; } }
    }

    enum Style
    {
        Sneaker,
        Loafer,
        Sandal,
        Flipflop,
        Wingtip,
        Clog,
    }
}
