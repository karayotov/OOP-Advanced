using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Missions
{

    public class Easy : Mission
    {
        private const int EASY_ENDURANCE = 20;

        private const string EASY_NAME = "Suppression of civil rebellion";

        private const int WEAR_LEVEL = 30;

        public Easy() { }

        public Easy(double scoreToComplete) : base(scoreToComplete)
        {
        }

        public override string Name => EASY_NAME;
        public override double EnduranceRequired => EASY_ENDURANCE;
        public override double WearLevelDecrement => WEAR_LEVEL;
    }
}
