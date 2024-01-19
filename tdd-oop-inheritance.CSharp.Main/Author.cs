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
        private string _contactInfo;
        private string _website;

        public string Name { get { return _name; } }
        public string ContactInfo { get { return _contactInfo; } }
        public string Website { get { return _website; } }

        public Author(string name, string contactInfo, string website)
        {
            _name = name;
            _contactInfo = contactInfo;
            _website = website;
        }
    }
}
