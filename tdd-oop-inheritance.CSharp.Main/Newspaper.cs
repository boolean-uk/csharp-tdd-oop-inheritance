﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryItems;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LibraryItem
    {
        public Newspaper(string title) : base(title) { }

        override public string checkIn()
        {
            return "newspapers are not available for loan";
        }

        public override string checkOut()
        {
            return "newspapers are not available for loan";
        }
    }
}
