using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CharacterLibrary
{
        class Skill {
                string Name;
                CharacterAttribute SkillAttribute;
                int Ranks;
                Boolean FavouredSkill;

                public Skill(string _Name, CharacterAttribute _SkillAttribute, int _Ranks, Boolean _FavouredSkill) {
                        Name = _Name;
                        SkillAttribute = _SkillAttribute;
                        Ranks = _Ranks;
                        FavouredSkill = _FavouredSkill;
                }
        }
}