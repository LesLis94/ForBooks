using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.BirdBook
{
    class VendingMachine
    {
        public virtual string Item {  get; }

        // protected - видимость только для субклассов, извне не виден
        protected virtual bool ChekAmount(decimal money) { return false; }

        public string Dispense(decimal money)
        {
            if (ChekAmount(money)) return Item;
            else return $"Please enter the right amount";
        }
    }

    class AnimalFeedVendingMachine : VendingMachine
    {
        public override string Item
        {
            get { return $"a handful of animal feed"; }
        }

        protected override bool ChekAmount(decimal money)
        {
            return money >= 1.25M;
        }
    }    
}
