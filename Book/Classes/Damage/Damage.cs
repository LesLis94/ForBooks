using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.Damage
{
    abstract class WeaponDamage
    {
        public int Roll { get { return Roll; } set {
                Roll = value;
                CalculateDamage(); ; } }
        public int Damage { get; protected set; }
        public bool Magic
        {
            get { return Magic; }
            set
            {
                Magic = value;
                CalculateDamage();
            }
        }
        public bool Flaming
        {
            get { return Flaming; }
            set
            {
                Flaming = value;
                CalculateDamage();
            }
        }
        protected abstract void CalculateDamage();

        public WeaponDamage(int startingRoll) {
            Roll = startingRoll;
            CalculateDamage();
        }
    }
}
