using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Book.Classes.BirdBook
{
    public abstract class Bird
    {
        public static Random Randomizer = new Random();
        public abstract Egg[] LayEggs(int numberOfEggs);
        // {
        //Console.Error.WriteLine("Bird.LayEggs should never get called");
        // return new Egg[0];
        // }

        public string Name { get; set; }
        public virtual void Fly(string destination)
        {
            Console.WriteLine($"{this} is flying to {destination}");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }

        public static void FlyAway(List<Bird> flock, string destination)
        {
            foreach (Bird bird in flock)
            {
                bird.Fly(destination);
            }
        }
    }

    public class Pigeon : Bird
        {
            private string color = "white";

            public override Egg[] LayEggs(int nnumberOfEggs)
            {
                Egg[] eggs = new Egg[nnumberOfEggs];

                for (int i = 0; i < nnumberOfEggs; i++)
                {
                    if (Bird.Randomizer.Next(4) == 0)
                        eggs[i] = new BrokenEgg(color);
                    else
                        eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, color);
                }

                return eggs;
            }
        }

    public class Ostrich : Bird
        {
            private string color = "speckled";

            public override Egg[] LayEggs(int nnumberOfEggs)
            {
                Egg[] eggs = new Egg[nnumberOfEggs];

                for (int i = 0; i < nnumberOfEggs; i++)
                {
                    eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, color);
                }

                return eggs;
            }
        }

}


