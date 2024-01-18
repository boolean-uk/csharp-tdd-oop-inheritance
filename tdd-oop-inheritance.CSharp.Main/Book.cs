using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryItem {

        Author author;
        bool onLoan = false;

        public Book(string title, Author author) : base(title) {
            this.author = author;
            this.title = title;
        }

        public Author getAuthor()
        {
            return author;
        }
    }
}
