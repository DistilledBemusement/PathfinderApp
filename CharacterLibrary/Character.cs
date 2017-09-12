using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace CharacterLibrary {
        public class Character {
                [PrimaryKey, AutoIncrement]
                public int ID { get; set; }
                public string Name;
                public CharacterAttribute STR = new CharacterAttribute(0);
                public CharacterAttribute DEX = new CharacterAttribute(0);
                public CharacterAttribute CON = new CharacterAttribute(0);
                public CharacterAttribute INT = new CharacterAttribute(0);
                public CharacterAttribute WIS = new CharacterAttribute(0);
                public CharacterAttribute CHA = new CharacterAttribute(0);
                public List<Skill> Skills { get; set; }

                public void SkillAdd (string Name, CharacterAttribute ATR, int Ranks, Boolean Favoured) {
                        Skill newSkill = new Skill(Name, ATR, Ranks, Favoured);
                        Skills.Add(newSkill);
                        // When the Ability to store this is available add a database insert
                }

                public override string ToString() {
                        return string.Format("[Character: Name={0}, STR={1}, DEX={2}, CON={3}, INT={4}, WIS={5}, CHA={6}]", 
                                Name, STR, DEX, CON, INT, WIS, CHA);
                }
        }
}
