public class Easy : Mission
{
    private const int ENDURANCE = 20;
    private const string NAME = "Suppression of civil rebellion";
    private const int WEAR_LEVEL = 30;


    public Easy(double scoreToComplete) : base(scoreToComplete)
    { }

    public override string Name => NAME;
    public override double EnduranceRequired => ENDURANCE;
    public override double WearLevelDecrement => WEAR_LEVEL;
}