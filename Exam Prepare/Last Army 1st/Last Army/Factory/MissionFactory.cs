﻿using System;
using System.Linq;
using System.Reflection;

public class MissionFactory : IMissionFactory
{
    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        var type = Assembly.GetCallingAssembly().GetTypes().Single(singleType => singleType.Name == difficultyLevel);

        return (IMission)Activator.CreateInstance(type, neededPoints);
    }
}
