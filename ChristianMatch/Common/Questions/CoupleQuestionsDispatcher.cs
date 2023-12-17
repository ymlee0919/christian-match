using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChristianMatch.Common
{
    class CoupleQuestionsDispatcher
    {
        private Dictionary<int, List<int>> hash;

        private Dictionary<int, int> indexes;

        private List<int> keys;

        private Questionary questionary;

        private Random rand;

        private int lastLevel;

        public CoupleQuestionsDispatcher()
        {
            this.lastLevel = -1;
            this.rand = new Random();

            this.hash = new Dictionary<int, List<int>>();
            this.indexes = new Dictionary<int, int>();
            this.keys = new List<int>();
            
            for (int i = 1; i <= 5; i++)
            {
                this.hash[i] = new List<int>();
                this.indexes[i] = 0;
            }
        }

        public void Open(string questionary)
        {
            string path = System.Environment.CurrentDirectory + "\\resources\\questionaries\\" + questionary.ToLower() + ".qst";
            Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            this.questionary = (Questionary)formatter.Deserialize(stream);
            stream.Close();

            // Fill hash
            int count = this.questionary.GetCount, level = 0;
            for (int i = 0; i < count; i++)
            {
                level = this.questionary[i].Level;
                this.hash[level].Add(i);
                this.indexes[level] = this.indexes[level] + 1;
            }

            // Delete empty category
            for (int i = 1; i <= 5; i++)
            {
                if (this.indexes[i] <= 1)
                {
                    this.hash.Remove(i);
                    this.indexes.Remove(i);
                }
                else
                    this.keys.Add(i);
            }
        }

        private void reset()
        {
            this.indexes = new Dictionary<int, int>();

            foreach (int level in this.hash.Keys)
            {
                this.indexes[level] = this.hash[level].Count;
                this.keys.Add(level);
            }
        }

        public Question GetNext()
        {
            int key = -1;

            if (this.lastLevel == -1)
            {
                if (this.keys.Count == 1)
                    key = this.keys[0];
                else
                {
                    key = this.rand.Next(0, this.keys.Count);
                    key = this.keys[key];
                }
            }
            else
                key = this.lastLevel;

            int index = this.indexes[key];

            int ptr = this.rand.Next(0, index);
            int number = this.hash[key][ptr];
            this.hash[key][ptr] = this.hash[key][this.indexes[key] - 1];
            this.indexes[key] = this.indexes[key] - 1;

            if (this.lastLevel != -1)
            {
                if (this.indexes[key] <= 1)
                {
                    this.indexes.Remove(key);
                    this.keys.Remove(key);
                }
                this.lastLevel = -1;
            }
            else
                this.lastLevel = key;

            if (this.keys.Count == 0)
                this.reset();

            this.questionary.GoTo(number);

            return this.questionary.GetCurrent;
        }

        public int Remainder
        {
            get
            {
                int count = 0;
                foreach (int c in this.indexes.Values)
                    count += c;

                return count;
            }
        }
    }
}
