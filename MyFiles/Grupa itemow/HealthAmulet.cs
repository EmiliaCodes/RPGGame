using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Game.Engine.Items
{
    [Serializable]
    class HealthAmulet : Item
    {
        public HealthAmulet() : base("item1082")
        {
            PublicName = "HealthAmulet";
            PublicTip = "adds 40 points of health";
            GoldValue = 80;
            HpMod = 40;
        }
    }
}
