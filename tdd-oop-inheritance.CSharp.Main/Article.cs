using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem
    {
        public Author Author { get; set; }

        public Article(string title, Author author) : base(title)
        {
            this.title = title;
            this.Author = author;
        }
    }
}
