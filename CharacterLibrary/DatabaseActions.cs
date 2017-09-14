using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Widget;
using SQLite;
using System.IO;

namespace CharacterLibrary { 
        public class DatabaseActions {
                string dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                const string location = "PFDB1";
                public static string Root { get; set; }
                SQLiteConnection Connection { get; }

                public DatabaseActions() {
                        Connection = new SQLiteConnection(Path.Combine(/* dbPath or Root */dbPath, location));
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

                public String[] AllSkills() {
                        List<Character> allchar = GetAllCharacters();
                        HashSet<string> uni_items = new HashSet<string>();
                        foreach (Character x in allchar) {
                                foreach (Skill y in x.Skills) {
                                        uni_items.Add(y.Name);
                                }
                        } String[] list = uni_items.ToArray<String>();
                        return list;
                }

                public List<Character> AllSkillGroups(string skillName) {
                        List<Character> charlist = GetAllCharacters();                        
                        foreach (Character x in charlist) {
                                bool InOrOut = false;
                                foreach (Skill y in x.Skills) {
                                        if (y.Name.Equals(skillName)) {
                                                InOrOut = true;
                                        }
                                }
                                if (InOrOut == false) {
                                        charlist.Remove(x);
                                }
                        } return charlist;
                }
        }
}