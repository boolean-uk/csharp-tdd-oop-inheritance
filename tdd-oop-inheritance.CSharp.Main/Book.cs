﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Library {
        public string title;

        

        public Book(string title) {
            this.title = title;
        }

       
    }
}