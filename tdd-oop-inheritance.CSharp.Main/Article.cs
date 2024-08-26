using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Item {

        public Author author { get; set; }

        public Article(Author author, string title) : base(title) {
            this.author = author;
        }
    }
}
