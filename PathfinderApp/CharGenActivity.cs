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

namespace PathfinderApp {
        [Activity(Label = "CharGenActivity")]
        public class CharGenActivity : ListActivity {
                DatabaseActions instance = new DatabaseActions();
                List<Character> charList = null;
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);
                        SetContentView(Resource.Layout.CharGen);
                        var instance = new DatabaseActions();
                        Button AddCharacterButton = FindViewById<Button>(Resource.Id.buttonAddNew);
                        Button DeleteCharacterButton = FindViewById<Button>(Resource.Id.buttonDelete);
                        ListView CharacterList = FindViewById<ListView>(Resource.Id.listViewCharacter);
                        charList = instance.GetAllCharacters();
                        var ListAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, charList);

                        AddCharacterButton.Click += (sender, e) => {
                                var intent = new Intent(this, typeof(AddCharacterActivity));
                                StartActivity(intent);
                        };
                }
        
                protected override void OnListItemClick(ListView l, View v, int position, long id) {
                        int pos = charList[position].ID;
                        var CharInfo = new Intent(this, typeof(CharacterInformationActivity));
                        CharInfo.PutExtra("Character", pos);
                        StartActivity(CharInfo);
                }
        }
}