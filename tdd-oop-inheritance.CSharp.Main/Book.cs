using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Item 
    {
        public Author Author { get; }
        public Book(string title, Author author) : base(title)
        {
            Author = author;
        }
    }
}
