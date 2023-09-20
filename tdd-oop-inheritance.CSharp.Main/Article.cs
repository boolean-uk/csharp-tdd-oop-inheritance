using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem
    {
        public Author Author { get; }

        public Article(string title, Author author) : base(title)
        {
            Author = author;
        }
    }
}
