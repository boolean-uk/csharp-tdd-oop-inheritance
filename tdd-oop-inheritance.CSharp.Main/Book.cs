using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibItem
    {

        private Author _author;

        public Book(string title, Author author)
        {
            this.title = title;
            _author = author;
        }
    }
}
