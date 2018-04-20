using System.Collections.Generic;

public class Ranker : Soldier
{
    private const double OVERALL_SKILL_MULTYPLIER = 1.5d;

    public Ranker(string name, int age, double experience, double endurance)
    : base(name, age, experience, endurance)
    {
    }

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet",
    };


    protected override List<string> WeaponsAllowed => weaponsAllowed;

    protected override double OverallSkillMultiplier => OVERALL_SKILL_MULTYPLIER;

}