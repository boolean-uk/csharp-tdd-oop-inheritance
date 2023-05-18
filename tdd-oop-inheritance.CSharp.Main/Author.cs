using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string name { get; set; }
        public string website { get; set; }

        public string contact { get; set; }

        public Author(string name, string website, string contact) {
            this.name = name;
            this.website = website;
            this.contact = contact;
        }

    }
}
