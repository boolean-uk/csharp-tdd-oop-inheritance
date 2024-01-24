using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Website { get; set; }

        public Author(string name, string contact, string website)
        {
            Name = name;
            Contact = contact;
            Website = website;
        }
    }
}
