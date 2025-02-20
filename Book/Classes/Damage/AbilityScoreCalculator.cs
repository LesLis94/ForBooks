using System;
namespace Book.Classes.Damage
{
    public class AbilityScoreCalculator
    {

        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        //public const int MINIMUM = 3;
        public int Score;

        public AbilityScoreCalculator()
        {
        }


        public void CalculateAbilityScore()
        {
            double divided = RollResult / DivideBy;

            int added = AddAmount + (int)divided;

            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }

        }



    }
}

