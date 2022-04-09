using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProgrammersDictionary
{
    public class Data
    {
        private readonly Dictionary<string, string> _words;
        private const string _fileName = "data.dat";
        private WordStorage _wordStorage;

        public Data()
        {
            _words = LoadFile();
        }

        public List<string> GetWords()
        {
            return _words.Keys.ToList<string>();
        }

        public string GetTranslation(string word)
        {
            if (_words.ContainsKey(word) == false)
            {
                return string.Empty;
            }

            return _words[word];
        }

        public void Add(string word, string translation)
        {
            word = word.Trim();
            translation = translation.Trim();

            if (_words.ContainsKey(word))
                return;
            _words.Add(word, translation);
        }

        public void Delete(string word)
        {
            if (_words.ContainsKey(word) == false)
                return;
            _words.Remove(word);
        }

        public void Edit(string word, string newWord, string newTranslation)
        {
            if(word == newWord)
            {
                _words[word] = newTranslation;
                return;
            }

            _words.Remove(word);
            _words.Add(newWord, newTranslation);
        }

        public void SaveFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, _wordStorage);
            }
        }

        private Dictionary<string, string> LoadFile()
        {
            if (File.Exists(_fileName) == false)
            {
                _wordStorage = new WordStorage();
                return _wordStorage.GetDictionary();
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                _wordStorage = (WordStorage)binaryFormatter.Deserialize(fs);
            }

            return _wordStorage.GetDictionary();
        }

    }
}
