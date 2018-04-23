using System.Collections.Generic;
using System.Text;

public class SpecialForce : Soldier
{
    private const double OVERALL_SKILL_MULTIPLIER = 3.5;

    private const int SPECIAL_FORCE_REGENERATION = 30;

    private readonly List<string> weaponsAllowed = new List<string>
        {
            nameof(Gun),
            nameof(AutomaticMachine),
            nameof(MachineGun),
            nameof(RPG),
            nameof(Helmet),
            nameof(Knife),
            nameof(NightVision)
        };

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }

    protected override int Regeneration => SPECIAL_FORCE_REGENERATION;

    protected override double OverallSkillMultiplier => OVERALL_SKILL_MULTIPLIER;

    protected override List<string> WeaponsAllowed => weaponsAllowed;
}