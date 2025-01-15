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
        public int tlf;
        public string website;

        public Author(string name, int tlf, string website)
        {
            this.name = name;
            this.tlf = tlf;
            this.website = website;
        }
    }
}
