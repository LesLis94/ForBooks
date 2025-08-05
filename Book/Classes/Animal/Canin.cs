using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.Animal
{
    abstract class Canin : Animal
    {
        public bool BelongsToPack {  get; protected set; } = false;
    }
}
