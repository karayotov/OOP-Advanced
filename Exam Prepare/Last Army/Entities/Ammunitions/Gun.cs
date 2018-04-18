using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class Gun : Ammunition
    {
        public const double WEIGHT = 1.4d;

        public override double Weight => WEIGHT;
    }
}