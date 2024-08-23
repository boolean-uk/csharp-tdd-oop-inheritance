using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem
    {
        private Author _author;

        public Article(Author author, string title) : base(title) 
        {
            _author = author; 
        }

    }
}
