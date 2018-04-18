using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Last_Army.Core
{
    public class SoldiersFactory : ISoldierFactory
    {
        public SoldiersFactory()
        {
        }
        //name, age, experience, speed, endurance, motivation, maxWeight

        public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
        {
            var type = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == soldierTypeName); //--- ако имаме Неймспейси(според Явор)
            return (ISoldier)Activator.CreateInstance(type, name, age, experience, endurance);
        }
    }
}



















