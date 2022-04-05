using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Engine.Monsters
{
    [Serializable]
    class Bee : Monster
    {
        public Bee(int beeLevel)
        {
            Health = 35 + 5 * beeLevel;
            Strength = 15 + beeLevel;
            Armor = 0;
            Precision = 70;
            MagicPower = 0;
            Stamina = 60;
            XPValue = 30 + beeLevel;
            Name = "monster1080";
            BattleGreetings = "You bother me! I'm going to sting you now!";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>()
                { 
                    new StatPackage("poison", 10, "Bee's venom burns in your veins (10 poison damage)")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Bee has no energy to attack anymore!") };
            }
        }

    }
}
