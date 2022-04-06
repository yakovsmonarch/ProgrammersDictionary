using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersDictionary
{
    [Serializable]
    class Data
    {
        private Dictionary<string, string> _words;

        public Data()
        {
            _words = new Dictionary<string, string>();
        }

        public List<string> GetWords()
        {
            List<string> wordsKey = new List<string>();
            foreach(string key in _words.Keys)
            {
                wordsKey.Add(key);
            }
            return wordsKey;
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

        public void Edit(string word, string newTranslation)
        {
            if (_words.ContainsKey(word) == false)
                return;
            _words[word] = newTranslation;
        }
    }
}
