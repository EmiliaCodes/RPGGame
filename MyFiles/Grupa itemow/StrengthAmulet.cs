using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.Amulet
{
    [Serializable]
    class StrengthAmulet : Item
    {
        public StrengthAmulet() : base("item1081")
        {
            PublicName = "StrengthAmulet";
            PublicTip = "for every 5 stamina points you get 1 extra strenght point";
            GoldValue = 50;
        }
        public override void ApplyBuffs(Engine.CharacterClasses.Player currentPlayer, List<string> otherItems)
        {
            currentPlayer.StrengthBuff += currentPlayer.Stamina / 5;
        }

    }
}
