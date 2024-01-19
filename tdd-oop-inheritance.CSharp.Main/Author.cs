using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string _name { get; }
        public string _number { get; }
        public string _website { get; }
        public Author(string name, string number, string website)
        {
            _name = name;
            _number = number;
            _website = website;
        }


    }
}
