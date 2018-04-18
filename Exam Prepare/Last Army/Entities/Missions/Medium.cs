using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Missions
{
    public class Medium : Mission
    {
        private const int ENDURANCE = 50;

        private const string NAME = "Capturing dangerous criminals";

        private const int WEAR_LEVEL = 50;

        public Medium() { }

        public Medium(double scoreToComplete) : base(scoreToComplete)
        {
            base.ScoreToComplete = scoreToComplete;
        }

        public override string Name => NAME;
        public override double EnduranceRequired => ENDURANCE;
        public override double WearLevelDecrement => WEAR_LEVEL;
    }
}
