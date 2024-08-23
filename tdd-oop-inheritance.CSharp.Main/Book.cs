using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Literature {

        private Author _author;

        public Book(Author author, string name) : base(name) { _author = author; }

        public Author Author { get { return _author; } }
    }
}
