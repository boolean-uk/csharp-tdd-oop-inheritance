using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : ItemClass
    {
        public string title;
        Author author;
        public Book(string title, Author author) : base(title, author)
        {
            this.title = title;
            this.author = author;
        }
    }
}
