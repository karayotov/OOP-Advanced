public class Medium : Mission
{
    private const int ENDURANCE = 50;
    private const string NAME = "Capturing dangerous criminals";
    private const int WEAR_LEVEL = 50;

    public Medium(double scoreToComplete) : base(scoreToComplete)
    { }

    public override string Name => NAME;
    public override double EnduranceRequired => ENDURANCE;
    public override double WearLevelDecrement => WEAR_LEVEL;
}
