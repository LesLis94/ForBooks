using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.BirdBook
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (Size > duckToCompare.Size) return 1;
            else if (Size < duckToCompare.Size) return -1;
            else return 0;
        }

        private string color = "speckled";

        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];

            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, color);
            }

            return eggs;
        }

        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }

    class DuckComparerBySize : IComparer<Duck>
    {

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
