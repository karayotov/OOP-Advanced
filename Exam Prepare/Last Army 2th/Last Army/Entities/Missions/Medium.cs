using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Medium : Mission
{
    private const string NAME = "Capturing dangerous criminals";

    private const double ENDURANCE = 50d;

    private const double WEAR_LEVEL = 50d;

    public Medium(double scoreToComplete) : base(scoreToComplete)
    { }

    public override string Name => NAME;

    public override double EnduranceRequired => ENDURANCE;

    public override double WearLevelDecrement => WEAR_LEVEL;
}
