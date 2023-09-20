using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string Name { get; }

        public string ContactInformation { get; }

        public string Website { get; }

        public Author(string name, string contactInfo, string website)
        {
            Name = name;
            ContactInformation = contactInfo;
            Website = website;
        }
    }
}
