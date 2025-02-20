using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Book.Interfaces;

namespace Book.Classes.Damage
{
    internal class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        public ArrowDamage(int startingRoll) : base(startingRoll) { }

        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;

            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
