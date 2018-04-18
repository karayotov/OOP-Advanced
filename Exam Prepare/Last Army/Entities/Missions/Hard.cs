using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Missions
{
    public class Hard : Mission
    {
        private const int ENDURANCE = 80;

        private const string NAME = "Disposal of terrorists";

        private const int WEAR_LEVEL = 70;

        public Hard() { }

        public Hard(double scoreToComplete) : base(scoreToComplete)
        {
            base.ScoreToComplete = scoreToComplete;
        }

        public override string Name => NAME;
        public override double EnduranceRequired => ENDURANCE;
        public override double WearLevelDecrement => WEAR_LEVEL;
    }
}
