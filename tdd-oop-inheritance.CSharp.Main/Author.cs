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
        public string email;
        public string website;

        public Author(string name, string email, string website)
        {
            this.name = name;
            this.email = email;
            this.website = website;
        }
    }
}