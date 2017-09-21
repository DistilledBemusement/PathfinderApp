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

namespace PathfinderApp {
        [Activity(Label = "EditCharacterActivity")]
        public class EditCharacterActivity : Activity {
                protected override void OnCreate(Bundle savedInstanceState) {
                        base.OnCreate(savedInstanceState);
                        SetContentView(Resource.Layout.EditCharacter);
                        Button EditPersonButton = FindViewById<Button>(Resource.Id.EditPersonButton);
                        EditText eceditName, eceditSTR, eceditDEX, eceditCON, 
                                eceditINT, eceditWIS, eceditCHA;
                        TextView ectextStrMod, ectextDexMod, ectextConMod, 
                                ectextIntMod, ectextWisMod, ectextChaMod;
                        eceditName = FindViewById<EditText>(Resource.Id.eceditTextName);
                        eceditSTR = FindViewById<EditText>(Resource.Id.eceditTextSTR);
                        eceditDEX = FindViewById<EditText>(Resource.Id.eceditTextDEX);
                        eceditCON = FindViewById<EditText>(Resource.Id.eceditTextCON);
                        eceditINT = FindViewById<EditText>(Resource.Id.eceditTextINT);
                        eceditWIS = FindViewById<EditText>(Resource.Id.eceditTextWIS);
                        eceditCHA = FindViewById<EditText>(Resource.Id.eceditTextCHA);
                        ectextStrMod = FindViewById<TextView>(Resource.Id.ectextStrMod);
                        ectextDexMod = FindViewById<TextView>(Resource.Id.ectextDexMod);
                        ectextConMod = FindViewById<TextView>(Resource.Id.ectextConMod);
                        ectextIntMod = FindViewById<TextView>(Resource.Id.ectextIntMod);
                        ectextWisMod = FindViewById<TextView>(Resource.Id.ectextWisMod);
                        ectextChaMod = FindViewById<TextView>(Resource.Id.ectextChaMod);
                }
        }
}