﻿using System;
using System.Collections.Generic;
using System.Linq;
public class Army : IArmy
{
    private List<ISoldier> soldiers;

    public IReadOnlyList<ISoldier> Soldiers => this.soldiers;

    public Army()
    {
        this.soldiers = new List<ISoldier>();
    }

    public void AddSoldier(ISoldier soldier)
    {
        this.soldiers.Add(soldier);
    }

    public void RegenerateTeam(string soldierType)
    {
        foreach (var soldier in this.soldiers.Where(soldier => soldier.GetType().Name == soldierType))
        {
            soldier.Regenerate();
        }
    }
}