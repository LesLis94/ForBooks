﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Book.Interfaces;

namespace Book.Classes
{
    internal class SwordDamage : IDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        private int roll;
        public int Roll { get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            } 
        }

        //private decimal MagicMultiplier = 1M;
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

        public SwordDamage(int startingRoll)
        {
            Roll = startingRoll;
            //CalculateDamage();
        }

        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;

            Damage = (int) (Roll * magicMultiplier) + BASE_DAMAGE;

            if (flaming) Damage += FLAME_DAMAGE;
        }

        

      /*  public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }*/

    }
}
