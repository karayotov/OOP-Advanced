public interface IWareHouse
{
    void EquipArmy(IArmy army);

    void AddAmmunition(string ammoName, int quantity);

    bool TryEquipSoldier(ISoldier soldier);
}