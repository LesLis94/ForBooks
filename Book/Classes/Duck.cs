using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes
{
    class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind {  get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size) return 1;
            else if (this.Size < duckToCompare.Size) return -1; 
            else return 0;
        }

        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }

    class DuckComparerBySize : IComparer<Duck> { 
    
        public int Compare(Duck x, Duck y)
        {
            if (x.Size > y.Size) return -1;
            else if (x.Size < y.Size) return 1;
            else return 0;
        }
    
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon
    }
}
