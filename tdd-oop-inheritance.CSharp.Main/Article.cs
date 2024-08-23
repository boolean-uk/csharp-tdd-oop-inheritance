using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Literature {

        private Author _author;
        public Article(Author author, string name) : base(name) { _author = author; }

        public Author Author { get { return _author; } }
    }
}
