using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using CharacterLibrary;
using System;

namespace PathfinderApp {
        [Activity(Label = "AddCharacterActivity")]
        public class AddCharacterActivity : Activity {
                DatabaseActions instance = new DatabaseActions();
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);
                        SetContentView(Resource.Layout.AddCharacter);
                        Character newCharacter = new Character();
                        Button AddPersonButton = FindViewById<Button>(Resource.Id.AddPersonButton);
                        EditText editName, editSTR, editDEX, editCON, editINT, editWIS, editCHA;
                        TextView textStrMod, textDexMod, textConMod, textIntMod, textWisMod, textChaMod;
                        editName = FindViewById<EditText>(Resource.Id.editTextName);
                        editSTR = FindViewById<EditText>(Resource.Id.editTextSTR);
                        editDEX = FindViewById<EditText>(Resource.Id.editTextDEX);
                        editCON = FindViewById<EditText>(Resource.Id.editTextCON);
                        editINT = FindViewById<EditText>(Resource.Id.editTextINT);
                        editWIS = FindViewById<EditText>(Resource.Id.editTextWIS);
                        editCHA = FindViewById<EditText>(Resource.Id.editTextCHA);
                        textStrMod = FindViewById<TextView>(Resource.Id.textStrMod);
                        textDexMod = FindViewById<TextView>(Resource.Id.textDexMod);
                        textConMod = FindViewById<TextView>(Resource.Id.textConMod);
                        textIntMod = FindViewById<TextView>(Resource.Id.textIntMod);
                        textWisMod = FindViewById<TextView>(Resource.Id.textWisMod);
                        textChaMod = FindViewById<TextView>(Resource.Id.textChaMod);

                        AddPersonButton.Click += (sender, e) => {
                                newCharacter.Name = editName.Text;
                                newCharacter.STR.AttributeScore = Convert.ToInt32(editSTR.Text);
                                newCharacter.DEX.AttributeScore = Convert.ToInt32(editDEX.Text);
                                newCharacter.CON.AttributeScore = Convert.ToInt32(editCON.Text);
                                newCharacter.INT.AttributeScore = Convert.ToInt32(editINT.Text);
                                newCharacter.WIS.AttributeScore = Convert.ToInt32(editWIS.Text);
                                newCharacter.CHA.AttributeScore = Convert.ToInt32(editCHA.Text);
                                instance.CharacterCreate(this, newCharacter);
                                var intent = new Intent(this, typeof(CharGenActivity));
                                StartActivity(intent);
                        };
                        editName.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                                newCharacter.Name = editName.Text;
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