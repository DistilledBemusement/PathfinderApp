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
using SQLite;
using System.IO;
using System.Collections;

namespace CharacterLibrary { 
        public class DatabaseActions {
                // string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "PFDB1");
                const string location = "PFDB1";
                public static string Root { get; set; }
                SQLiteConnection Connection { get; }

                public DatabaseActions() {
                        Connection = new SQLiteConnection(Path.Combine(Root, location));
                        Connection.CreateTable<Character>();
                        Connection.CreateTable<Skill>();
                }
                
                public void CharacterCreate(Context con, Character Chara) {
                        try {
                                Connection.Insert(Chara);
                                Toast.MakeText(con, "Record Added Successfully", ToastLength.Short).Show();
                        } catch (Exception ex) {
                                Toast.MakeText(con, ex.ToString(), ToastLength.Short).Show();
                        }
                }

                public Character GetCharacter(int id) {
                        var items = (from i in Connection.Table<Character>() where i.ID == id select i);
                        return items.Any() ? items.ElementAt(0) : null;
                }       

                public List<Character> GetAllCharacters() {
                        var items = Connection.Table<Character>();
                        List<Character> things = new List<Character>();
                        foreach(Character x in items) {
                                things.Add(x);
                        } return things;
                }

                public List<Character> GetSkill(string _name) {
                        List<Character> charlist = GetAllCharacters();
                        List<Character> reqSkill = new List<Character>();
                        foreach (Character x in charlist) {
                                foreach (Skill y in x.Skills) {
                                        if (y.Name.Equals(_name)) {
                                                reqSkill.Add(x);
                                        }
                                }
                        } return reqSkill;
                }

                public ArrayList AllSkillGroups() {
                        List<Character> allchar = GetAllCharacters();
                        HashSet<string> uni_items = new HashSet<string>();
                        foreach (Character x in allchar) {
                                foreach (Skill y in x.Skills) {
                                        uni_items.Add(y.Name);
                                }
                        } ArrayList sg = new ArrayList();
                        foreach (string nam in uni_items) {
                                List<Character> refChar = new List<Character>();
                                ArrayList sgi = new ArrayList();
                                foreach (Character x in allchar) {
                                        foreach (Skill y in x.Skills) {
                                                if (y.Name.Equals(nam)) {
                                                        refChar.Add(x);
                                                }
                                        }
                                } sgi.Add(nam);
                                sgi.Add(refChar);
                                sg.Add(sgi);
                        } return sg;
                }
        }
}