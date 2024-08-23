using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem {
        private Author _author;
        public Author Author { get => _author; }
        public Article(string title, Author author) : base(title) 
        {
            _author = author;
        }
    }
}
