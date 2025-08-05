using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Interfaces;

namespace Book.Classes
{
    class TallGuy : IClown
    {
        public string Name { get; set; }
        public int Height { get; set; }

        public string FunnyThingIHave { get { return "big shoes"; } }

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I' m {Height} inches tall");
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
}
