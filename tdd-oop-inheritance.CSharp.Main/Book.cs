using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Item
    {
        private IAuthor _author;
        public Book(string title, IAuthor author) : base(title)
        {
            _author = author;
        }

        public IAuthor Author { get { return _author; } set { _author = value; } }
    }
}
