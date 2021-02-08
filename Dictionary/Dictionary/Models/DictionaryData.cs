using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Models
{
    public class DictionaryData
    {
        private string key;

        private string meaning;
        private string explaination;
        
        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }
        public string Explaination
        {
            get { return explaination; }
            set { explaination = value; }
        }
    }
}
