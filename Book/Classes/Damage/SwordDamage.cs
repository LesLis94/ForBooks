using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Book.Interfaces;

namespace Book.Classes.Damage
{
    internal class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public SwordDamage(int startingRoll) : base(startingRoll)
        {
            Roll = startingRoll;
        }

        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;

            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}
