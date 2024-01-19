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
        private string _contactInfo;
        private string _website;

        public Author(string name, string contactInfo, string website)
        {
            _name = name;
            _contactInfo = contactInfo;
            _website = website;
        }

        public string Name { get => _name; set => _name = value; }
        public string ContactInformation { get => _contactInfo; set => _contactInfo = value; }
        public string WebSite { get => _website; set => _website = value; }
    }
}
