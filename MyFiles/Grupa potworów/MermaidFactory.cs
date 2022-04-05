using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Engine.Monsters.MonsterFactories
{
    [Serializable]
    class MermaidFactory : MonsterFactory
    {
        private int encounterNumber = 0;
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber == 0)
            {
                encounterNumber++;
                return new Mermaid(playerLevel);
            }
            else return null;
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) return new Mermaid(0).GetImage();
            else return null;
        }
    }
}
