using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : InventoryItem, Item
    {
        public string title;
        public Author _author;

        public Book(string title) {
            this.title = title;
            _author = new Author(string.Empty, string.Empty, string.Empty);

        }
        public Book(string title, Author author)
        {
            this.title = title;
            _author = author;
        }

        public Author Author { get { return _author; } }
    }
}
