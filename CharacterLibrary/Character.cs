using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterLibrary
{
        public class Character {
                public string Name;
                public CharacterAttribute STR = new CharacterAttribute();
                public CharacterAttribute DEX = new CharacterAttribute();
                public CharacterAttribute CON = new CharacterAttribute();
                public CharacterAttribute INT = new CharacterAttribute();
                public CharacterAttribute WIS = new CharacterAttribute();
                public CharacterAttribute CHA = new CharacterAttribute();

                public void SkillAdd (string Name, CharacterAttribute ATR, int Ranks, Boolean Favoured) {
                        Skill newSkill = new Skill(Name, ATR, Ranks, Favoured);
                        // When the Ability to store this is available add a database insert
                }
        }
}
