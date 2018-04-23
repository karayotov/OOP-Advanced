using NUnit.Framework;

public class MissionControllerTests
{
    [Test]
    public void MissionControllerDisplayFailMessage()
    {
        var army = new Army();
        var wareHouse = new WareHouse();
        var missionControler = new MissionController(army, wareHouse);

        var mission = new Easy(1);
        string result = "";

        for (int counter = 0; counter < 4; counter++)
        {
            result = missionControler.PerformMission(mission);
        }

        Assert.IsTrue(result.StartsWith("Mission declined - Suppression of civil rebellion"));
    }

    [Test]
    public void MissionControllerDisplaySuccessMessage()
    {
        var army = new Army();
        var wareHouse = new WareHouse();
        var missionControler = new MissionController(army, wareHouse);

        var mission = new Easy(0);
        string result = missionControler.PerformMission(mission);

        Assert.IsTrue(result.StartsWith("Mission completed - Suppression of civil rebellion"));
    }
}
