using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes
{
    class Lumberjack
    {
        public string Name { get; set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack> ();

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push (flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjackStack.Count > 0) { 
                var flapjack = flapjackStack.Pop();
                Console.WriteLine($"{Name} ate a {flapjack} flapjack");
            }
            
        }
    }

    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana
    }
}
