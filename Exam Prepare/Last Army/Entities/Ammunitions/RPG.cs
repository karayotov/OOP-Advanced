using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class RPG : Ammunition
    {
        public const double WEIGHT = 17.1d;

        public override double Weight => WEIGHT;

    }
}