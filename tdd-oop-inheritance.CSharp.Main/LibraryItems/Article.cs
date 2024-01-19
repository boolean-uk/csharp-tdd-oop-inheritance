using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace LibraryItems
{
    public class Article(string title, Author author) : LibraryItem(title)
    {
        public Author Author { get; } = author;
    }
}
