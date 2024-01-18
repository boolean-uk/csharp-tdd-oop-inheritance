using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        private string _name;
        private string _phonenumber;
        private string _website;

        public string Name { get { return _name; } }
        public Author(string name)
        {
            _name = name;
        }
    }
}
