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


    public void RequestResult()
    {
        missionController.FailMissionsOnHold();
        writer.AppendLine(OutputMessages.Results);
        writer.AppendLine(string.Format(OutputMessages.SuccessfulMissionsCount, missionController.SuccessMissionCounter));
        writer.AppendLine(string.Format(OutputMessages.FailedMissionsCount, missionController.FailedMissionCounter));
        writer.AppendLine(OutputMessages.Soldiers);

        foreach (var soldier in this.army.Soldiers.OrderByDescending(soldier => soldier.OverallSkill))
        {
            writer.AppendLine(soldier.ToString());
        }

    } 

    public void GiveInputToGameController(string input)
    {
        var data = input.Split();

        if (data[0].Equals("Soldier"))
        {

            if (data[1] == "Regenerate")
            {
                army.RegenerateTeam(data[2]);
            }
            else
            {
                var soldier = soldierFactory.CreateSoldier 
                    (
                        data[1],                //string soldierTypeName
                        data[2],                //string name
                        int.Parse(data[3]),     //int age
                        double.Parse(data[4]),  //double experience
                        double.Parse(data[5])   //double endurance
                    );

                if (this.wareHouse.TryEquipSoldier(soldier))
                {
                    this.army.AddSoldier(soldier);
                }
                else
                {
                    string soldierType = data[1];
                    string soldierName = data[2];
                    throw new ArgumentException(string.Format(OutputMessages.SoldierCannotBeEquiped, soldierType, soldierName));
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
            var mission = this.missionFactory.CreateMission(data[1], double.Parse(data[2]));

            writer.AppendLine(this.missionController.PerformMission(mission).Trim());
        }
    }
}