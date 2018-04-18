using Last_Army.Core;
using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private double endurance;
    

    protected virtual IReadOnlyList<string> WeaponsAllowed { get; }



    public string Name { get; private set; }

    public int Age { get; private set; }

    public double Endurance { get; private set; }

    public double Experience { get; private set; }

    public IDictionary<string, IAmmunition> Weapons { get; private set; }


    public virtual double OverallSkill { get; private set; }

    
    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }
        
        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0; //👀

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;//👀
    }

    private void AmmunitionRevision(double missionWearLevelDecrement)
    {
        IEnumerable<string> keys = this.Weapons.Keys.ToList();

        foreach (string weaponName in keys)
        {
            this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

            if (this.Weapons[weaponName].WearLevel <= 0)
            {
                this.Weapons[weaponName] = null;
            }
        }
    }

    public void Regenerate()
    {
        throw new System.NotImplementedException();
    }

    public void CompleteMission(IMission mission)
    {
        throw new System.NotImplementedException();
    }

    public override string ToString() => string.Format(OutputMessages.SoldierToString(), this.Name, this.OverallSkill);
}