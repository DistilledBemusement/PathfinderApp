using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace PathfinderApp { 
        [Activity(Label = "Pathfinder App", MainLauncher = true)]
        public class MainActivity : Activity {
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);

                        // Set our view from the "main" layout resource
                        SetContentView(Resource.Layout.Main);
                        Button CharGenButton = FindViewById<Button>(Resource.Id.CharGenButton);
                        Button DiceRollerButton = FindViewById<Button>(Resource.Id.SkillSelectButton);

                        CharGenButton.Click += (sender, e) => {
                                var intent = new Intent(this, typeof(CharGenActivity));
                                StartActivity(intent);
                        };

                        DiceRollerButton.Click += (sender, e) => {
                                var intent = new Intent(this, typeof(DiceRollerActivity));
                                StartActivity(intent);
                        };
                }
        }
}

