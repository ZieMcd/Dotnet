using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    class HttpCookie
    {                
        public DateTime Expiry { get; set; }
        private readonly Dictionary<string, string> _dictionary =  new Dictionary<string, string>(); // <key type, data type> name


        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
