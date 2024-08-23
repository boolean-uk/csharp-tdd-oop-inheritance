using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : ReadingMaterial {

        public Author WrittenBy { get; }

        public Book(string title, Author author) : base(title)
        {
            WrittenBy = author;
        }


    }
}
