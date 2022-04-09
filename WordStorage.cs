using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersDictionary
{
    [Serializable]
    class WordStorage
    {
        private Dictionary<string, string> _dictionary { get; set; }

        public WordStorage()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public Dictionary<string, string> GetDictionary()
        {
            return _dictionary;
        }
    }
}
