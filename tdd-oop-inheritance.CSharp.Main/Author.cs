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
        private string _email;
        public Author(string name, string email)
        {
            _name = name;
            _email = email;
        }
        public string Name { get { return _name; } }
        public string Email { get { return _email; } }
    }
}
