using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameController
{
    private IArmy army;
    private IWareHouse wareHouse;
    private MissionController missionController;
    private ISoldierFactory soldierFactory;
    private IMissionFactory missionFactory;
    private IWriter writer;

    public GameController(IWriter writer)
    {
        this.army = new Army();
        this.wareHouse = new WareHouse();
        this.missionController = new MissionController(army, wareHouse);
        this.soldierFactory = new SoldierFactory();
        this.missionFactory = new MissionFactory();
        this.writer = writer;
    }

    public void GiveInputToGameController(string input)
    {

        var data = input.Split();

        string givenType = data[0];

        string givenCommand = data[1];

        if (givenType.Equals("Soldier"))
        {
            if (givenCommand == "Regenerate")
            {
                army.RegenerateTeam(givenType);
            }
            else
            {
                var soldier = this.soldierFactory.CreateSoldier
                    (
                        data[1],                //type
                        data[2],                //name
                        int.Parse(data[3]),     //age
                        double.Parse(data[4]),  //experience
                        double.Parse(data[5])   //endurance
                    );

                if (this.wareHouse.TryEquipSoldier(soldier))
                {
                    this.army.AddSoldier(soldier);
                }
                else
                {
                    throw new ArgumentException(string.Format(OutputMessages.SoldierCannotBeEquiped, data[1], data[2]));
                }
            }
        }

        else if (data[0].Equals("WareHouse"))
        {
            string name = data[1];
            int number = int.Parse(data[2]);

            this.wareHouse.AddAmmunition(name, number);
        }
        else if (data[0].Equals("Mission"))
        {
            var mission = missionFactory.CreateMission(data[1], double.Parse(data[2]));
            writer.AppendLine(this.missionController.PerformMission(mission).Trim());
        }
    }

    public void RequestResult()
    {
        this.missionController.FailMissionsOnHold();

        this.writer.AppendLine(OutputMessages.Results);

        this.writer.AppendLine(string.Format(OutputMessages.SuccessfulMissionCount, missionController.SuccessMissionCounter));

        this.writer.AppendLine(string.Format(OutputMessages.FailedMissionsCount, missionController.FailedMissionCounter));

        this.writer.AppendLine(OutputMessages.Soldiers);

        foreach (var soldier in this.army.Soldiers.OrderByDescending(soldier => soldier.OverallSkill))
        {
            this.writer.AppendLine(soldier.ToString());
        }
    }
}