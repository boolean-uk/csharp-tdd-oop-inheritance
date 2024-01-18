using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book: LibraryItem {

        List<Author> _authors;
        public Book(string title, List<Author> Authors) : base(title) {
            _authors = Authors;
        }
    }
}
