using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Book.Interfaces;

namespace Book.Classes
{
    internal class ArrowDamage : IDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        private int roll;
        public int Roll { get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            } 
        }

        private int FlamingDamage = 0;
        private int damage; 
        public int Damage { get; private set; }

        private bool magic;
        public bool Magic {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        public ArrowDamage(int startingRoll) => Roll = startingRoll;//CalculateDamage();

        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (magic) baseDamage *= MAGIC_MULTIPLIER;

            if (flaming) Damage = (int) Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int) Math.Ceiling(baseDamage);
        }


    }
}
