﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryItem
    {
        public Book( string title) : base(title)
        {
        }

        public Book(Author author, string title) : base(author, title)
        {
        }
    }
}
