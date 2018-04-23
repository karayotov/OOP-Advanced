using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class SoldierFactory : ISoldierFactory
{
    public ISoldier CreateSoldier(string soldierType, string name, int age, double experience, double endurance) //--- Reflection example 👀
    {
        var type = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == soldierType);

        return (ISoldier)Activator.CreateInstance(type, name, age, experience, endurance);
    }
}