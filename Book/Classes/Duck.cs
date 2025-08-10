using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes
{
    class Duck
    {
        public int Size { get; set; }
        public KindOfDuck Kind {  get; set; }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon
    }
}
