using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterLibrary
{
        public class Character {
                string Name;
                CharacterAttribute STR = new CharacterAttribute();
                CharacterAttribute DEX = new CharacterAttribute();
                CharacterAttribute CON = new CharacterAttribute();
                CharacterAttribute INT = new CharacterAttribute();
                CharacterAttribute WIS = new CharacterAttribute();
                CharacterAttribute CHA = new CharacterAttribute();

                public void SkillAdd (string Name, CharacterAttribute ATR, int Ranks, Boolean Favoured) {
                        Skill newSkill = new Skill(Name, ATR, Ranks, Favoured);
                        // When the Ability to store this is available add a database insert
                }
        }
}
