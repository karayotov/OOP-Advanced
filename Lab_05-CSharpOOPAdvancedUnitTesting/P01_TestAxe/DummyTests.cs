using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public class DummyTests
    {
        [Test]

        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 1500);

            dummy.TakeAttack(1);

            Assert.That(dummy.Health, Is.EqualTo(9), "Dummy Health doesn't change after attack.");
        }

        [Test]

        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(10, 1500);

           dummy.TakeAttack(10);

           Assert.That(() => dummy.TakeAttack(0), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));

        }

        //[TestCase(0)]
        //[TestCase(-1)]
        //public void IsDead_ReturnsDead(int health)
        //{
        //    var dummy = new Dummy(health, 10);
        //    Assert.That(dummy.IsDead(), Is.EqualTo(true));
        //}

        private static int xp = 15;

        [Test]

        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(1, 15);

            dummy.TakeAttack(1);

            Assert.That(dummy.GiveExperience(), Is.EqualTo(xp));
        }

        [Test]

        public void DeadDummyCanotGiveXP()
        {
            Dummy dummy = new Dummy(1, 15);

            dummy.TakeAttack(1);

            Assert.That(dummy.GiveExperience(), Is.EqualTo(xp));
        }
    }
}
