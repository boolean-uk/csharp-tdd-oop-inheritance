using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        private string _name;
        private string _info;
        private string _url;
        public Author(string name, string contactInfo, string website) 
        {
            _name = name;
            _info = contactInfo;
            _url = website;
        }
        public string Name { get => _name; }
        public string ContactInfo { get => _info; }
        public string Website { get => _url; }
    }
}
