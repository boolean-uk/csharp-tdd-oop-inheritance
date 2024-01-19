using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryMaterial {
        public string title;

        bool onLoan = false;

        public Book(string title) {
            this.title = title;
        }

    }
}
