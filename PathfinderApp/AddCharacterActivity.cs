using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using CharacterLibrary;
using System;

namespace PathfinderApp
{
        [Activity(Label = "AddCharacterActivity")]
        public class AddCharacterActivity : Activity {
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);

                        // Create your application here
                        SetContentView(Resource.Layout.AddCharacter);
                        Character newCharacter = new Character();
                        Button AddPersonButton = FindViewById<Button>(Resource.Id.AddPersonButton);
                        EditText editSTR = FindViewById<EditText>(Resource.Id.editTextSTR);
                        EditText editDEX = FindViewById<EditText>(Resource.Id.editTextDEX);
                        EditText editCON = FindViewById<EditText>(Resource.Id.editTextCON);
                        EditText editINT = FindViewById<EditText>(Resource.Id.editTextINT);
                        EditText editWIS = FindViewById<EditText>(Resource.Id.editTextWIS);
                        EditText editCHA = FindViewById<EditText>(Resource.Id.editTextCHA);
                        TextView textStrMod = FindViewById<TextView>(Resource.Id.textStrMod);
                        TextView textDexMod = FindViewById<TextView>(Resource.Id.textDexMod);
                        TextView textConMod = FindViewById<TextView>(Resource.Id.textConMod);
                        TextView textIntMod = FindViewById<TextView>(Resource.Id.textIntMod);
                        TextView textWisMod = FindViewById<TextView>(Resource.Id.textWisMod);
                        TextView textChaMod = FindViewById<TextView>(Resource.Id.textChaMod);

                        AddPersonButton.Click += (sender, e) => {
                                // For when you can add the newCharacter to the database

                                var intent = new Intent(this, typeof(CharGenActivity));
                                StartActivity(intent);
                        };
                        editSTR.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                                CharacterAttribute newAttr = new CharacterAttribute(Convert.ToInt32(editSTR.Text));
                                newCharacter.STR = newAttr;
                                textStrMod.Text = Convert.ToString(newAttr.AttributeModifer);
                        };
                        editDEX.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                                CharacterAttribute newAttr = new CharacterAttribute(Convert.ToInt32(editSTR.Text));
                                newCharacter.DEX = newAttr;
                                textDexMod.Text = Convert.ToString(newAttr.AttributeModifer);
                        };
                        editCON.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                                CharacterAttribute newAttr = new CharacterAttribute(Convert.ToInt32(editSTR.Text));
                                newCharacter.CON = newAttr;
                                textConMod.Text = Convert.ToString(newAttr.AttributeModifer);
                        };
                        editINT.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                                CharacterAttribute newAttr = new CharacterAttribute(Convert.ToInt32(editSTR.Text));
                                newCharacter.INT = newAttr;
                                textIntMod.Text = Convert.ToString(newAttr.AttributeModifer);
                        };
                        editWIS.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                                CharacterAttribute newAttr = new CharacterAttribute(Convert.ToInt32(editSTR.Text));
                                newCharacter.WIS = newAttr;
                                textWisMod.Text = Convert.ToString(newAttr.AttributeModifer);
                        };
                        editCHA.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                                CharacterAttribute newAttr = new CharacterAttribute(Convert.ToInt32(editSTR.Text));
                                newCharacter.CHA = newAttr;
                                textChaMod.Text = Convert.ToString(newAttr.AttributeModifer);
                        };
                }
        }
}