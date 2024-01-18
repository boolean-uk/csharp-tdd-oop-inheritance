using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        string _name;
        string _contactInfo;
        string _website;
        public Author(string name, string contactInfo, string website)
        {
            _name = name;
            _contactInfo = contactInfo;
            _website = website;
        }
    }
}
