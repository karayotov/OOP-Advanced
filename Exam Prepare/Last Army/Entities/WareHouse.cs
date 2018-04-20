using System.Collections.Generic;
using System.Linq;

public class WareHouse : IWareHouse
{

    private Dictionary<string, int> ammunitionsQuantities;

    private IAmmunitionFactory ammunitionFactory;

    public WareHouse()
    {
        this.ammunitionsQuantities = new Dictionary<string, int>();
        this.ammunitionFactory = new AmmunitionFactory();
    }

    public void AddAmmunition(string ammoName, int quantity)
    {
        if (this.ammunitionsQuantities.ContainsKey(ammoName))
        {
            ammunitionsQuantities[ammoName] += quantity;
        }
        else
        {
            ammunitionsQuantities.Add(ammoName, quantity);
        }
    }

    public void EquipArmy(IArmy army)
    {
        foreach (var soldier in army.Soldiers)
        {

        }
    }
     
    public bool TryEquipSoldier(ISoldier soldier)
    {
        List<string> wornOutWeapons = soldier.Weapons.Where(weapon => weapon.Value == null).Select(weapon => weapon.Key).ToList();

        bool isSoldierEquiped = true;

        foreach (var weapon in wornOutWeapons)
        {
            if (ammunitionsQuantities.ContainsKey(weapon) && ammunitionsQuantities[weapon] > 0)
            {
                soldier.Weapons[weapon] = ammunitionFactory.CreateAmmunition(weapon);
                ammunitionsQuantities[weapon]--;
            }
            else
            {
                isSoldierEquiped = false;
            }
        }

        return isSoldierEquiped;
    }
}

