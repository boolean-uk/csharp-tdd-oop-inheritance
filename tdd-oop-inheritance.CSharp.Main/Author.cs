using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string name { get; }
        public string mail { get; }
        public string website { get; }

        public Author(string name, string mail, string website) 
        {
            this.name = name;
            this.mail = mail;
            this.website = website;
        }
    }
}
