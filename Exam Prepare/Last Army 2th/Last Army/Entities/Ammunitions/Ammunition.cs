using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Ammunition : IAmmunition
{
    private const int WEAR_LEVEL_MULTIPLIER = 100;

    public Ammunition()
    {
        this.WearLevel = this.Weight * WEAR_LEVEL_MULTIPLIER;
    }

    public string Name => this.GetType().Name;

    public abstract double Weight { get; }

    public double WearLevel { get; private set; }

    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel -= wearAmount;
    }
}
