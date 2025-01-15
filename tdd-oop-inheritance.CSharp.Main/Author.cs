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
        public string contactInfo;
        public string? website;


        public Author(string _name, string _contactInfo, string? _website)
        {
            name = _name;
            contactInfo = _contactInfo;
            website = _website;
        }
}
}
