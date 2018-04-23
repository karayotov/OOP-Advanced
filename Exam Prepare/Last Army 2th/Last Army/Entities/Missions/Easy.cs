
public class Easy : Mission
{
    private const string NAME = "Suppression of civil rebellion";

    private const double ENDURANCE = 20d;

    private const double WEAR_LEVEL = 30d;

    public Easy(double scoreToComplete) : base(scoreToComplete)
    { }

    public override string Name => NAME;

    public override double EnduranceRequired => ENDURANCE;

    public override double WearLevelDecrement => WEAR_LEVEL;
}