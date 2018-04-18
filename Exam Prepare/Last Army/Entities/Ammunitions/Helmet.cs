using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class Helmet : Ammunition
    {
        public const double WEIGHT = 2.3d;

        public override double Weight => WEIGHT;

    }
}