﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Readable, IAuthor
    {
        public Article(string title, Author author)
        {
            this.title = title;
            this.Author = author;
        }
        public Author Author { get; set; }
    }
}
