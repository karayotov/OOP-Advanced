using System.Collections.Generic;

public class SpecialForce : Soldier
{
    private const int SPECIAL_FORCE_REGENERATE_INCREASE = 30;

    private const double OVERALL_SKILL_MULTYPLIER= 3.5d;


    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet",
        "Knife",
        "MachineGun",
        "NightVision",
        "RPG",
    };

    protected override int RegenerateIncrease => SPECIAL_FORCE_REGENERATE_INCREASE;

    protected override List<string> WeaponsAllowed => weaponsAllowed;

    protected override double OverallSkillMultiplier => OVERALL_SKILL_MULTYPLIER;


}