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
        private string _website;

        public Author()
        {
            
        }

        public string writtenBy()
        {
            return "Written by " + this.Name;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get => _email; set => _email = value; }
        public string Website { get => _website; set => _website = value; }

    }
}
