using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article(string title, Author author) : Item(title)
    {
        public Author Author { get; } = author;
    }
}
