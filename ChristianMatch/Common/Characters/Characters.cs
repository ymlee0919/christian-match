using System;
using System.Collections.Generic;
using System.Text;

namespace ChristianMatch.Common
{
    struct Character 
    {
        public string Name, FileName;
        public System.Drawing.Image Image;
        public System.Drawing.Image ImageRTL;
        public System.Drawing.Image ImageLTR;
        public char gender;

        public Character(string name, string file, char gender)
        {
            this.Name = name;
            this.FileName = file;
            this.Image = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\characters\\" + file + ".jpg");
            this.ImageRTL = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\players\\" + file + "-rtl.jpg");
            this.ImageLTR = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\players\\" + file + "-ltr.jpg");
            this.gender = gender;
        }
    }

    class Characters
    {
        private Dictionary<string, Character> items = null;

        private static Characters instance = null;

        private System.Drawing.Image none = null;

        private Characters()
        {
            this.items = new Dictionary<string, Character>();

            this.items["david"] = new Character("David", "david", 'm');
            this.items["elias"] = new Character("Elías", "elias", 'm');
            this.items["josue"] = new Character("Josué", "josue", 'm');
            this.items["sara"] = new Character("Sara", "sara", 'f');
            this.items["juan"] = new Character("Juan", "juan", 'm');
            this.items["moises"] = new Character("Moisés", "moises", 'm');
            this.items["pablo"] = new Character("Pablo", "pablo", 'm');
            this.items["ester"] = new Character("Ester", "ester", 'f');
            this.items["pedro"] = new Character("Pedro", "pedro", 'm');
            this.items["salomon"] = new Character("Salomón", "salomon", 'm');
            this.items["sanson"] = new Character("Sansón", "sanson", 'm');
            this.items["maria"] = new Character("María", "maria", 'f');

            this.none = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\characters\\none.png");
        }

        public static void Load()
        {
            if (Characters.instance == null)
                Characters.instance = new Characters();
        }

        public static Characters Instance
        {
            get 
            {
                if (Characters.instance == null)
                    Characters.instance = new Characters();

                return Characters.instance;
            }
        }

        public Character this[string alias]
        {
            get
            {
                if (this.items.ContainsKey(alias))
                    return this.items[alias];
                return new Character();
            }
        }

        public List<string> ItemsNames
        {
            get
            {
                return new List<string>(this.items.Keys);
            }
        }

        public System.Drawing.Image None
        {
            get
            {
                return this.none;
            }
        }
    }
}
