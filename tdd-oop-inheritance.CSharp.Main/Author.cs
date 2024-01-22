using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interfaces;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author : IAuthor
    {
        private string _name;
        private string _contactInformation;
        private string _website;

        public string Name { get => _name; set => _name = value; }
        public string ContactInformation { get => _contactInformation; set => _contactInformation = value; }
        public string Website { get => _website; set => _website = value; }

        public Author(string name, string contactInformation, string website)
        {
            Name = name;
            ContactInformation = contactInformation;
            Website = website;
        }
    }
}
