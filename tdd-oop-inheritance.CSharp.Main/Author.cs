using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string name;
        public string contact;
        public string information;
        public string website;

        public Author(string name, string contact, string information, string website) {
            this.name = name;
            this.contact = contact;
            this.information = information;
            this.website = website;
        }
    }
}
