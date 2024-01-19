using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article :InventoryItem, Item
    {
        public Author _author;
        public Article(string title, Author author) {
            this.Title = title;
            _author = author;
        }
        public Article(string title)
        {
            this.Title = title;
            _author = new Author(string.Empty,string.Empty,string.Empty);
        }

        public Author Author { get { return _author; } }
    }
}
