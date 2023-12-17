using System;
using System.Collections.Generic;
using System.Text;

namespace ChristianMatch.Common
{
    struct Character 
    {
        public string Name, FileName;
        public System.Drawing.Image Image;

        public Character(string name, string file)
        {
            this.Name = name;
            this.FileName = file;
            this.Image = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\characters\\" + file);
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

            this.items["david"] = new Character("David", "david.jpg");
            this.items["elias"] = new Character("Elías", "elias.jpg");
            this.items["josue"] = new Character("Josué", "josue.jpg");
            this.items["sara"] = new Character("Sara", "sara.jpg");
            this.items["juan"] = new Character("Juan", "juan.jpg");
            this.items["moises"] = new Character("Moisés", "moises.jpg");
            this.items["pablo"] = new Character("Pablo", "pablo.jpg");
            this.items["ester"] = new Character("Ester", "ester.jpg");
            this.items["pedro"] = new Character("Pedro", "pedro.jpg");
            this.items["salomon"] = new Character("Salomón", "salomon.jpg");
            this.items["sanson"] = new Character("Sansón", "sanson.jpg");
            this.items["maria"] = new Character("María", "maria.jpg");

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
