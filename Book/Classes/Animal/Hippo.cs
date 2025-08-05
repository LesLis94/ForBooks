using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Interfaces;

namespace Book.Classes.Animal
{
    class Hippo : Animal, ISwimmer
    {
        public override void MakeNois()
        {
            Console.WriteLine($"Grunt.");
        }
        public void Swim()
        {
            Console.WriteLine($"Splash! I'm going for a swim");
        }
    }
}
