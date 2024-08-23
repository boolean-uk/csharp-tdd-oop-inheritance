using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Paper 
    {
        public string title;

        bool onLoan = false;

        public Book(string title) : base(title) {}
    }
}
