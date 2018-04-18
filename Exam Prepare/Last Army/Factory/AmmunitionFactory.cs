using System;
using System.Linq;
using System.Reflection;

namespace Last_Army.Factory
{
    public class AmmunitionFactory: IAmmunitionFactory
    {
        public AmmunitionFactory()
        {
        }

        public IAmmunition CreateAmmunition(string name)
        {
            var type = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == name); //--- ако имаме Неймспейси(според Явор)
            return (IAmmunition)Activator.CreateInstance(type);
        }
    }
}