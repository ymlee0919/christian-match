using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChristianMatch.Common
{
    class SimpleQuestionsDispatcher
    {
        private Questionary questionary;

        private int index;

        private int[] list;

        private Random rand;

        public SimpleQuestionsDispatcher()
        {
            this.rand = new Random();
        }

        public void Open(string questionary)
        {
            string path = System.Environment.CurrentDirectory + "\\resources\\questionaries\\" + questionary.ToLower() + ".qst";
            Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            this.questionary = (Questionary)formatter.Deserialize(stream);
            stream.Close();

            this.index = this.questionary.GetCount - 1;
            this.list = new int[this.questionary.GetCount];

            for (int i = 0; i < list.Length; i++)
                list[i] = i;
        }

        public Question GetNext()
        {
            if (this.index <= 0)
            {
                this.index = this.questionary.GetCount - 1;
                Array.Sort(this.list);
            }

            int r = this.rand.Next(0, this.index);
            int index = this.list[r];
            this.list[r] = this.index;
            this.index--;

            this.questionary.GoTo(index);

            return this.questionary.GetCurrent;
        }

        public int Remainder
        {
            get
            {
                return this.index;
            }
        }

    }
}
