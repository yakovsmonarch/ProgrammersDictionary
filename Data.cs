using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammersDictionary
{
    [Serializable]
    public class Data
    {
        private readonly Dictionary<string, string> _words;

        public Data()
        {
            _words = new Dictionary<string, string>();
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
    }
}
