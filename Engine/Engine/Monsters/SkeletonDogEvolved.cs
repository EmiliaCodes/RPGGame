using System;
using System.Collections.Generic;

namespace Game.Engine.Monsters
{
    [Serializable]
    class SkeletonDogEvolved : Monster
    {
        public SkeletonDogEvolved(int dogLevel)
        {
            Health = 50 + 5 * dogLevel;
            Strength = 10 + dogLevel;
            Armor = 0;
            Precision = 50;
            MagicPower = 0;
            Stamina = 70;
            XPValue = 40 + dogLevel;
            Name = "monster1082";
            BattleGreetings = "You defeated me but now I'm back with venom!";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>()
                {
                     new StatPackage("stab", 5 + Strength, "Skeleton dog bites you! (" + (5 + Strength) + " stab damage)"),
                     new StatPackage("poison", 20, "Venom from dog bite burns in your veins (15 poison damage)")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Rat has no energy to attack anymore!") };
            }
        }
    }
}
