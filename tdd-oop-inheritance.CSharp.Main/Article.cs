using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem {

        List<Author> authors;
        public Article(string title, List<Author> Authors) : base(title) {
            authors = Authors;
        }
    }
}
