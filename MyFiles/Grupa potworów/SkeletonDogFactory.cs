using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters.MonsterFactories
{
    [Serializable]
    class SkeletonDogFactory:MonsterFactory
    {
        private int encounterNumber = 0;
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber == 0)
            {
                encounterNumber++;
                return new SkeletonDog(playerLevel);
            }
            else if (encounterNumber == 1)
            {
                encounterNumber++;
                return new SkeletonDogEvolved(playerLevel);
            }
            else return null;
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) return new SkeletonDog(0).GetImage();
            else if (encounterNumber == 1) return new SkeletonDogEvolved(0).GetImage();
            else return null;
        }
    }
}
