using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.BirdBook
{
    public class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }

        public Egg(double size, string color) { 
            Size = size;
            Color = color;
        }

        public string Description { get {
                return $"A {Size:0.0} cm {Color} egg";
            } }

    }

    public class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base(0, $"broken  {color}") 
        {
            Console.WriteLine($"A bird laid a broken egg");
        }
    }
}
