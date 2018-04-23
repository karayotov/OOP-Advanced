
using System;
using System.Collections.Generic;
using System.Linq;


public abstract class Soldier : ISoldier
{
    private const double MAX_ENDURANCE = 100;

    private const int BASE_REGENERATION = 10;

    private double endurance;

    protected virtual int Regeneration => BASE_REGENERATION;

    protected Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Weapons = new Dictionary<string, IAmmunition>();
        this.Endurance = endurance;

        foreach (var weapon in this.WeaponsAllowed)
        {
            this.Weapons.Add(weapon, null);
        }
    }

    public string Name { get; }

    public int Age { get; }

    public double Experience { get; private set; }

    public double Endurance
    {
        get { return endurance; }
        protected set
        {
            endurance = Math.Min(value, MAX_ENDURANCE);
        }
    }

    protected abstract double OverallSkillMultiplier { get; }

    public double OverallSkill => (this.Age + this.Experience) * OverallSkillMultiplier;

    protected abstract List<string> WeaponsAllowed { get; }

    public IDictionary<string, IAmmunition> Weapons { get; }

    public void CompleteMission(IMission mission)
    {
        this.Experience += mission.EnduranceRequired;
        this.Endurance -= mission.EnduranceRequired;

        foreach (var weapon in this.Weapons.Values.Where(weapon => weapon != null).ToList())
        {
            weapon.DecreaseWearLevel(mission.WearLevelDecrement);

            if (weapon.WearLevel <= 0)
            {
                this.Weapons[weapon.Name] = null;
            }
        }
    }

    public bool ReadyForMission(IMission mission)
    {
        bool insufficientEndurance = this.Endurance < mission.EnduranceRequired;

        bool incompleateEquipment = this.Weapons.Values.Any(weapon => weapon == null);

        bool notAllAmmonitionsHavePositiveWearLevel = this.Weapons.Values.Any(weapon => weapon.WearLevel == 0);


        if (insufficientEndurance)
        {
            return false;
        }

        if (incompleateEquipment)
        {
            return false;
        }

        if (notAllAmmonitionsHavePositiveWearLevel)
        {
            return false;
        }

        return true;
    }

    public void Regenerate()
    {
        this.Endurance += this.Regeneration + this.Age;
    }

    public override string ToString()
    {
        return string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);
    }
}