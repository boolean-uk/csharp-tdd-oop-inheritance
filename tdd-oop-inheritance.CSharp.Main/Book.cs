using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryItem
    {
        public Author Author { get; }

        public Book(string title, Author author) : base(title)
        {
            Author = author;
        }
    }
}
