using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    //Slightly modified to enherit from LibraryClass, and have author as property
    public class Book : LibraryItem {
        public Author author { get; set; }
        public Book(string title) : base(title)
        {

        }
    }
}
