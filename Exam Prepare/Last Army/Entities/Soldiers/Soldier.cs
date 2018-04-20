using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private const int BASE_REGENERATE_INCREASE = 10;
    
    private const int MAX_ENDURANCE = 100;

    private double endurance;

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
        private set
        {
            endurance = Math.Min(value, MAX_ENDURANCE);
        }
    }

    protected virtual int RegenerateIncrease => BASE_REGENERATE_INCREASE;

    protected abstract double OverallSkillMultiplier { get; }

    public double OverallSkill => (this.Age + this.Experience) * this.OverallSkillMultiplier;

    protected abstract List<string> WeaponsAllowed { get; }

    public IDictionary<string, IAmmunition> Weapons { get; }

    public void CompleteMission(IMission mission)
    {
        this.Experience += mission.EnduranceRequired;
        this.Endurance -= mission.EnduranceRequired;

        foreach (var weapon in Weapons.Values.Where(w => w != null).ToList()) //с ToList() правим нова колекция, за да не гърми(пълним колекция докато я обхождаме)
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
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.All(weapon => weapon != null); //👀

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.All(weapon => weapon.WearLevel > 0);//👀
    }

    public void Regenerate()
    {
        this.Endurance += this.Age + this.RegenerateIncrease;
    }

    public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);

}