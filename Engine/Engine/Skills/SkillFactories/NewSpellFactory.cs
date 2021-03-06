using Game.Engine.CharacterClasses;
using Game.Engine.Skills.BasicSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.SkillFactories
{
    [Serializable]
    class NewSpellFactory : SkillFactory
    {
        public Skill CreateSkill(Player player)
        {
            List<Skill> playerSkills = player.ListOfSkills;
            Skill known = CheckContent(playerSkills); // check what spells from the BasicSpells category are known by the player already
            if (known == null) // no BasicSpells known - we will return one of them
            {
                SoulEater s1 = new SoulEater();
                PoisonTornado s2 = new PoisonTornado();
                WaterBlast s3 = new WaterBlast();
                // only include elligible spells
                List<Skill> tmp = new List<Skill>();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1); // check level requirements
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (s3.MinimumLevel <= player.Level) tmp.Add(s3);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)]; // use Index.RNG for safe random numbers
            }
            else if (known.decoratedSkill == null) // a BasicSpell has been already learned, use decorator to create a combo
            {
                SoulEaterDecorator s1 = new SoulEaterDecorator(known);
                PoisonTornadoDecorator s2 = new PoisonTornadoDecorator(known);
                WaterBlastDecorator s3 = new WaterBlastDecorator(known);
                List<Skill> tmp = new List<Skill>();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1); // check level requirements
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (s3.MinimumLevel <= player.Level) tmp.Add(s3);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)];
            }
            else return null; // a combo of BasicSpells has been already learned - this factory doesn't offer double combos so we stop here
        }
        private Skill CheckContent(List<Skill> skills) // wrapper method for checking
        {
            foreach (Skill skill in skills)
            {
                if (skill is SoulEater || skill is PoisonTornado || skill is WaterBlast || skill is SoulEaterDecorator || skill is PoisonTornadoDecorator || skill is WaterBlastDecorator) return skill;
            }
            return null;
        }
    }
}
