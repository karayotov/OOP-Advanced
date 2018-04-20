public class Hard : Mission
{
    private const int ENDURANCE = 80;
    private const string NAME = "Disposal of terrorists";
    private const int WEAR_LEVEL = 70;

    public Hard(double scoreToComplete) : base(scoreToComplete)
    { }

    public override string Name => NAME;
    public override double EnduranceRequired => ENDURANCE;
    public override double WearLevelDecrement => WEAR_LEVEL;
}
