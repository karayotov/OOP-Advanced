using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities
{
    public abstract class Mission : IMission
    {

        public Mission() { }

        public Mission(double scoreToComplete)
        {
            this.ScoreToComplete = scoreToComplete;
        }

        public virtual string Name { get; protected set; }

        public virtual double EnduranceRequired { get; protected set; }

        public double ScoreToComplete { get; protected set; }

        public virtual double WearLevelDecrement { get; protected set; }

    }
}
