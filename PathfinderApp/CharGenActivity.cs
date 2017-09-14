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
        public class CharGenActivity : Activity {
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);
                        SetContentView(Resource.Layout.CharGen);
                        var instance = new DatabaseActions();
                        Button AddCharacterButton = FindViewById<Button>(Resource.Id.buttonAddNew);
                        Button DeleteCharacterButton = FindViewById<Button>(Resource.Id.buttonDelete);
                        ListView CharacterList = FindViewById<ListView>(Resource.Id.listViewCharacter);
                        List<Character> charList = instance.GetAllCharacters();
                        // seriously this is hard

                        AddCharacterButton.Click += (sender, e) => {
                                var intent = new Intent(this, typeof(AddCharacterActivity));
                                StartActivity(intent);
                        };

                        DeleteCharacterButton.Click += (sender, e) => {
                                var intent = new Intent(this, typeof(CharacterDeleteActivity));
                                StartActivity(intent);
                        };

                        //var items = instance.GetAllCharacters().ToList<Character>();
                        //var ListAdapter = new ArrayAdapter<String>(this, );
                }
        }
}