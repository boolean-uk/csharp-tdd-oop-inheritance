using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author : IAuthor
    {
        private string _name;
        private string _contactInformation;
        private string _website;

        public Author (string name, string contactInformation, string website)
        {
            _name = name;
            _contactInformation = contactInformation;
            _website = website;

        }

        public string Name { get { return _name; } set { _name = value; } }
        public string ContactInformation { get { return _contactInformation; } set { _contactInformation = value; } }
        public string Website { get { return _website; } set { _website = value; } }
    }
}

