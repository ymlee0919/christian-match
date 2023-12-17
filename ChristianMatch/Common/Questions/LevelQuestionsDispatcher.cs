using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChristianMatch.Common
{
    class LevelQuestionsDispatcher
    {
        private Dictionary<int, List<int>> hash;

        private Dictionary<int, int> indexes;

        private Questionary questionary;

        private Random rand;

        public LevelQuestionsDispatcher()
        {
            this.rand = new Random();

            this.hash = new Dictionary<int, List<int>>();
            this.indexes = new Dictionary<int, int>();

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
        }

        private void reset()
        {
            this.indexes = new Dictionary<int, int>();

            foreach (int level in this.hash.Keys)
                this.indexes[level] = this.hash[level].Count;
        }

        public bool isAllowed(int level)
        {
            return this.indexes[level] > 0;
        }

        public Question GetNext(int level)
        {
            int index = this.indexes[level];

            int ptr = this.rand.Next(0, index);
            int number = this.hash[level][ptr];
            this.hash[level][ptr] = this.hash[level][this.indexes[level] - 1];
            this.indexes[level] = this.indexes[level] - 1;

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
