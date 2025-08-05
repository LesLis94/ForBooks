using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Interfaces;

namespace Book.Classes.Animal
{
    class Wolf : Canin, IPackHunter
    {
        public Wolf(bool belongsToPack) {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNois()
        {
            if (BelongsToPack)
                Console.WriteLine($"I'm in a pack.");
            Console.WriteLine($"Aroooooo!");
        }
        public void HuntInPack()
        {
            if (!BelongsToPack)
                Console.WriteLine($"I'm going hunting with my pack");
            else
                Console.WriteLine($"I'm not in a pack");
        }
    }
}
