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
        public string ContactInfo { get; set; }
        public string Website { get; set; }
        public Author(string name, string contactinfo, string website)
        {
            Name = name;
            ContactInfo = contactinfo;
            Website = website;
        }
    }
}
