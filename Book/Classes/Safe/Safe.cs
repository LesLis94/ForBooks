using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.Safe
{
    class Safe
    {
        private string contents = $"precious jewels";
        private string safeCombination = "12345";

        public string Open(string combination)
        {
            if (combination == safeCombination) return contents;
            return "";
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = safeCombination;
        }
    }
    class SafeOwner
    {
        private string valuables = "";
        public void ReceiveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thank you for returing my {valuables}");
        }
    }

    class Locksmith
    {
        public string Combination {private get; set; }
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this);
            string safeContents = safe.Open(Combination);
            ReturnContents(safeContents, owner);
        }

        protected void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }   
    }



}
