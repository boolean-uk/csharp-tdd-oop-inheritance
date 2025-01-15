﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryItem {
        public string title;

        bool onLoan = false;

        Author author;

        public Book(Author author,string title) : base(title)
        {
            this.author = author;
        }

    }
}
