using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChristianMatch.Common.Questions
{
    class QuestionaryManager
    {
        /// <summary>
        /// Questionaries directory
        /// </summary>
        private string path;

        /// <summary>
        /// Singleton instance
        /// </summary>
        private static QuestionaryManager instance = null;

        /// <summary>
        /// Active questionary
        /// </summary>
        private Questionary activeQuestionary;

        /// <summary>
        /// Active questionary file
        /// </summary>
        private string activeFile;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        private QuestionaryManager()
        {
            this.activeFile = null;
            this.activeQuestionary = null;
            this.path = System.Environment.CurrentDirectory + "\\resources\\questionaries\\";
        }

        /// <summary>
        /// Return the unique instance of a questionary manager
        /// </summary>
        public static QuestionaryManager Instance
        {
            get
            {
                if (QuestionaryManager.instance == null)
                    QuestionaryManager.instance = new QuestionaryManager();

                return QuestionaryManager.instance;
            }
        }

        /// <summary>
        /// Convert a questionary name into a file name
        /// </summary>
        /// <param name="questionaryName">Name of questionary</param>
        /// <returns>The file name</returns>
        private string NameToFile(string questionaryName)
        {
            return questionaryName.ToLower()
                .Replace(' ', '_')
                .Replace('.', '_')
                .Replace('(', '_')
                .Replace(')', '_')
                .Replace('*', '_')
                .Replace('&', '_')
                .Replace("__", "_") + ".qst";
        }

        /// <summary>
        /// Convert the filename to a readeable name
        /// </summary>
        /// <param name="filename">File name</param>
        /// <returns>Readeable name</returns>
        private string FileToName(string filename)
        {
            if (!filename.EndsWith(".qst"))
                return null;

            filename = filename.Substring(filename.LastIndexOf('\\') + 1);

            filename = filename.Substring(0, filename.Length - 4);
            string[] parts = filename.Split('_');
            
            for(int i = 0; i < parts.Length; i++)
                parts[i] = parts[i].Substring(0, 1).ToUpper() + parts[i].Substring(1);

            return string.Join(" ", parts);
        }

        /// <summary>
        /// Check if the questionary exists
        /// </summary>
        /// <param name="questionaryName">The name of questionary to search for</param>
        /// <returns>True if exists, false if not</returns>
        public bool ExistsQuestionary(string questionaryName)
        {
            string fileName = this.NameToFile(questionaryName);

            return File.Exists(this.path + fileName);
        }

        /// <summary>
        /// Get the list of questionaries
        /// </summary>
        /// <returns></returns>
        public List<string> GetList()
        {
            // Get files from directory
            string[] files = Directory.GetFiles(this.path, "*.qst", SearchOption.TopDirectoryOnly);

            // Convert filename to name
            List<string> list = new List<string>();
            foreach (string file in files)
                list.Add(this.FileToName(file));

            return list;
        }

        /// <summary>
        /// Create a new questionary file given the name
        /// </summary>
        /// <param name="questionaryName">Name of the questionary</param>
        /// <returns>Questionary</returns>
        public Questionary Create(string questionaryName)
        {
            if (this.ExistsQuestionary(questionaryName))
                throw new Exception("The new questionary already exists. Please, provide another name.");

            // Build file name
            this.activeFile = this.NameToFile(questionaryName);
            string filePath = this.path + this.activeFile;

            // Create stream
            Stream stream = File.Open(filePath, FileMode.Create);
            // Create formatter
            BinaryFormatter formatter = new BinaryFormatter();
            // Create questionay
            this.activeQuestionary = new Questionary();

            // Serialize and write into stream
            formatter.Serialize(stream, this.activeQuestionary);

            // Close the stream
            stream.Close();


            return this.activeQuestionary;
        }

        /// <summary>
        /// Open a questionary given the name
        /// </summary>
        /// <param name="questionaryName">Name of questionary</param>
        /// <returns>Questionary</returns>
        public Questionary Open(string questionaryName)
        {
            this.activeFile = this.NameToFile(questionaryName);
            string filePath = this.path + this.activeFile;

            Stream stream = File.Open(filePath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            this.activeQuestionary = (Questionary)formatter.Deserialize(stream);
            stream.Close();

            return this.activeQuestionary;
        }

        /// <summary>
        /// Raname a questionary
        /// </summary>
        /// <param name="originalName">Original questionary name</param>
        /// <param name="newName">New name for the questionay</param>
        public void Rename(string originalName, string newName)
        {
            if (originalName == newName)
                return;

            // Validate the original file already exists
            if (!this.ExistsQuestionary(originalName))
                throw new InvalidOperationException("The questionary you want to rename do not exists.");

            // Validate the new name do not exists
            if(this.ExistsQuestionary(newName))
                throw new InvalidOperationException("The new questionary name already exists. Please, provide another name.");

            string originalFile = this.NameToFile(originalName);
            string destinationFile = this.NameToFile(newName);

            File.Move(this.path + originalFile, this.path + destinationFile);

            if (this.activeFile == originalFile)
                this.activeFile = destinationFile;
            
        }

        /// <summary>
        /// Delete a questionary given the name
        /// </summary>
        /// <param name="questionaryName">Name of questionary to delete</param>
        public void DeleteQuestionary(string questionaryName)
        {
            if (!this.ExistsQuestionary(questionaryName))
                throw new InvalidOperationException("The questionary you want to delete do not exists.");

            string fileName = this.NameToFile(questionaryName);

            if(this.activeFile == fileName)
                throw new InvalidOperationException("You can not delete the active questionary.");

            File.Delete(this.path);
        }

        /// <summary>
        /// Save the active questionary
        /// </summary>
        public void SaveActiveQuestionary()
        {
            Stream stream = File.Open(this.activeFile, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, this.activeQuestionary);
            stream.Close();
        }

        
    }
}
