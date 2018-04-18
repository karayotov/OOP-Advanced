using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class Knife : Ammunition
    {
        public const double WEIGHT = 0.4d;

        public override double Weight => WEIGHT;

    }
}