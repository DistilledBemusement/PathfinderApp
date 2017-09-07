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

namespace CharacterLibrary {
        public class CharacterAttribute {
                int AttributeScore;
                int AttributeModifer;

                public void CalculateModifer () {
                        double startingValue = (AttributeScore - 10) / 2;
                        if ((startingValue % 1) == 0) {
                                AttributeModifer = Convert.ToInt32(startingValue);
                        } else {
                                AttributeModifer = Convert.ToInt32(startingValue - 0.5);
                        }
                }
        }
}