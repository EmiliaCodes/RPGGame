using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items;

namespace Game.Engine.Items.ItemFactories
{
    [Serializable]
    class AmuletFactory :ItemFactory
    {
        public Item CreateItem()
        {
            List<Item> amulet = new List<Item>()
            {
                new HealthAmulet(),
                new AntiPoisonAmulet(),
                new StrengthAmulet()
            };
            return amulet[Index.RNG(0, amulet.Count)];
        }
        public Item CreateNonMagicItem()
        {
            return CreateItem();
        }
        public Item CreateNonWeaponItem()
        {
            return CreateItem();
        }
    }
}
