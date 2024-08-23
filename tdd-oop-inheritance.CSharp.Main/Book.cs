using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryItem
    {
        private Author _author;

        public Book(Author author, string title) : base(title) 
        {
            _author = author;
        }
    }
}
