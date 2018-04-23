using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WareHouse : IWareHouse
{
    private Dictionary<string, int> ammunitionsQuantities;

    private IAmmunitionFactory ammunitionFactory;

    public WareHouse()
    {
        this.ammunitionsQuantities = new Dictionary<string, int>();
        this.ammunitionFactory = new AmmunitionFactory();
    }

    public void AddAmmunition(string ammunition, int quantity)
    {
        if (ammunitionsQuantities.ContainsKey(ammunition))
        {
            ammunitionsQuantities[ammunition] += quantity;
        }
        else
        {
            ammunitionsQuantities.Add(ammunition, quantity);
        }
    }

    public void EquipArmy(IArmy army)
    {
        foreach (var soldier in army.Soldiers)
        {
            TryEquipSoldier(soldier);
        }
    }

    public bool TryEquipSoldier(ISoldier soldier)
    {
        var wornoutWeappons = soldier.Weapons
            .Where(weapon => weapon.Value == null)
            .Select(weapon => weapon.Key).ToList();

        bool isSoldierEquiped = true;

        foreach (var weapon in wornoutWeappons)
        {
            if (ammunitionsQuantities.ContainsKey(weapon) && ammunitionsQuantities[weapon] > 0)
            {
                soldier.Weapons[weapon] = this.ammunitionFactory.CreateAmmunition(weapon);
                this.ammunitionsQuantities[weapon]--;
            }
            else
            {
                isSoldierEquiped = false;
            }

        }

        return isSoldierEquiped;
    }
}
