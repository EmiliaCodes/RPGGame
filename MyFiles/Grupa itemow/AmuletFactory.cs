using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.Amulet;

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
            // MagicAmulet works only for mages
            List<Item> amulet = new List<Item>()
            {
                new AntiPoisonAmulet(),
                new StrengthAmulet()
            };
            return amulet[Index.RNG(0, amulet.Count)];
        }
        public Item CreateNonWeaponItem()
        {
            List<Item> amulet = new List<Item>()
            {
                new AntiPoisonAmulet(),
                new HealthAmulet(),
                new StrengthAmulet()
            };
            return amulet[Index.RNG(0, amulet.Count)];
        }
    }
}
