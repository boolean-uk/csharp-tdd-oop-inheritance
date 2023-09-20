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


        public Author(string name)
        {
            _name = name;
        }

        public string writtenBy()
        {
            return "Written by " + this.name;
        }

        public string name { get {  return _name; } }
    }
}
