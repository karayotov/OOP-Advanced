using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Hard : Mission
{
    private const string NAME = "Disposal of terrorists";

    private const double ENDURANCE = 80d;

    private const double WEAR_LEVEL = 70d;

    public Hard(double scoreToComplete) : base(scoreToComplete)
    { }

    public override string Name => NAME;

    public override double EnduranceRequired => ENDURANCE;

    public override double WearLevelDecrement => WEAR_LEVEL;
}
