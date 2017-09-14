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
using CharacterLibrary;
using System.Collections;

namespace PathfinderApp {
        [Activity(Label = "SkillRollSelectActivity")]
        public class SkillRollSelectActivity : ListActivity {
                DatabaseActions instance = new DatabaseActions();
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);
                        Button RollButton = FindViewById<Button>(Resource.Id.RollButton);
                        CheckBox cbNega = FindViewById<CheckBox>(Resource.Id.cbNega);
                        EditText etModifier = FindViewById<EditText>(Resource.Id.etModifier);
                        SetContentView(Resource.Layout.SkillRollSelect);
                        String text = Intent.GetStringExtra("SkillType");
                        List<Character> characters = instance.AllSkillGroups(text);
                        
                        RollButton.Click += (sender, e) => {
                                int result; Random rnd = new Random();
                                string resultContent = "Result is as follows: ";                               
                                foreach (Character chara in characters) {
                                        result = rnd.Next(1, 20);
                                        Skill sk = chara.Skills.Find(item => item.Name == text);
                                        result += sk.Ranks + sk.SkillAttribute.AttributeModifer;
                                        //somehow add in a section for extra stuff like items
                                        if (sk.FavouredSkill && sk.Ranks > 0) {
                                                result += 3;
                                        }
                                        if (etModifier.Text != null) {
                                                if (cbNega.Checked) {
                                                        result -= Convert.ToInt32(etModifier.Text);
                                                } else if (cbNega.Checked == false) {
                                                        result += Convert.ToInt32(etModifier.Text);
                                                }
                                        }
                                        resultContent += "\r\n" + chara.Name + ": " + result;
                                 } Toast.MakeText(this, resultContent, ToastLength.Short);
                        };

                        ListView CharacterListView = FindViewById<ListView>(Resource.Id.lvCharacter);
                        ListAdapter = new ArrayAdapter<Character>(this, Android.Resource.Layout.SimpleListItem1, characters);
                }
        }
}