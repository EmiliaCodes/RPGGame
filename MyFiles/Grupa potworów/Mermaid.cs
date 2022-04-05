using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class Mermaid : Monster
    {
        public Mermaid(int mermaidLevel)
        {
            Health = 40 + 5 * mermaidLevel;
            Strength = 15;
            Armor = 10;
            Precision = 45;
            MagicPower = 25 + mermaidLevel;
            Stamina = 50;
            XPValue = 20 + mermaidLevel;
            Name = "monster1083";
            BattleGreetings = "Hello handsome human, come closer...";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {   
                if(MagicPower >= 10 + (int)(MagicPower * 0.2))
                {
                    Stamina -= 10;
                    MagicPower -= 10 + (int)(MagicPower*0.2);
                    return new List<StatPackage>() { new StatPackage("water", 10 + (int)(MagicPower * 0.2), "Mermaid uses water blast! (" + (10 + (int)(MagicPower * 0.1)) + " water damage)") };
                }
                else
                {
                    Stamina -= 10;
                    return new List<StatPackage>() { new StatPackage("cut", 5, "Mermaid is too tired for magic, but she cuts you! (5 cut damage)") };
                }         
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Mermaid has no energy to attack anymore!") };
            }
        }
    }
}
