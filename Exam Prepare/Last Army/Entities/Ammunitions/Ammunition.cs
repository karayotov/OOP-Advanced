using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Ammunitions
{
    public abstract class Ammunition : IAmmunition
    {
        private const int WEAR_LEVEL_MULTIPLIER = 100;

        protected Ammunition()
        {
            this.WearLevel = Weight * WEAR_LEVEL_MULTIPLIER;
        }

        public string Name => this.GetType().Name;     //{ get; }
        public abstract double Weight { get; }    //{ get; }
        public double WearLevel { get; private set; }

        public void DecreaseWearLevel(double wearAmount)
        {
            if (true)
            {
                //mission is not compleated, throw exception?
            }

            this.WearLevel -= wearAmount;
        }
        
    }
}