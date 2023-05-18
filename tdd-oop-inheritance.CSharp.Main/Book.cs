using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interface;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Library {
        public string title;

        public IAuhtor _author;

        public Book(string title, IAuhtor author) {
            this.title = title;
            _author = author;
        }

       
    }
}
