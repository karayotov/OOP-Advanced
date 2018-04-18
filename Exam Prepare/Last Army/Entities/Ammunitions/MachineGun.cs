using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class MachineGun : Ammunition
    {
        public const double WEIGHT = 10.6d;

        public override double Weight => WEIGHT;

    }
}