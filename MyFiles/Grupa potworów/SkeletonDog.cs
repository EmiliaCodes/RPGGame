using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class SkeletonDog : Monster
    {
        public SkeletonDog(int dogLevel)
        {
            Health = 30 + 10 * dogLevel;
            Strength = 10 + dogLevel;
            Armor = 0;
            Precision = 50;
            MagicPower = 0;
            Stamina = 50;
            XPValue = 20 + dogLevel;
            Name = "monster1081";
            BattleGreetings = "I may be a skeleton but I can bite hard!";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>() { new StatPackage("stab", 5 + Strength, "Skeleton dog bites you! (" + (5 + Strength) + " stab damage)") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Skeleton dog has no energy to attack anymore!") };
            }
        }
    }
}
