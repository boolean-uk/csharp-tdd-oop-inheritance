using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Item
    {
        private Author _author;
        public Book(string title, Author author) : base(title)
        {
            _author = author;
        }
        public Author Author { get { return _author; } }
    }
}
