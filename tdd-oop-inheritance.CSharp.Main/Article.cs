﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem, IItemExtended
    {
        public Article(string title) : base(title)
        {
        }

        public Author Author { get; set; }
    }
}
