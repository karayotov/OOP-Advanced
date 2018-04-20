using System.Collections.Generic;

public class Corporal : Soldier
{
    private const double OVERALL_SKILL_MULTYPLIER = 2.5d;

    public Corporal(string name, int age, double experience, double endurance)
    : base(name, age, experience, endurance)
    {
    }

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet",
        "Knife",
    };


    protected override List<string> WeaponsAllowed => weaponsAllowed;

    protected override double OverallSkillMultiplier => OVERALL_SKILL_MULTYPLIER;

}