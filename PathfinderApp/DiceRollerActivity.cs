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
        [Activity(Label = "DiceRoller")]
        public class DiceRollerActivity : ListActivity {
                DatabaseActions instance = new DatabaseActions();
                String[] items;
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);
                        SetContentView(Resource.Layout.DiceRoller);
                        items = instance.AllSkills();
                        ListView SkillListView = FindViewById<ListView>(Resource.Id.SkillsListView);
                        ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
                }

                protected override void OnListItemClick(ListView l, View v, int position, long id) {
                        String pos = items[position];
                        var SkillRoller = new Intent(this, typeof(SkillRollSelectActivity));
                        SkillRoller.PutExtra("SkillType", pos);
                        StartActivity(SkillRoller);
                }
        }
}