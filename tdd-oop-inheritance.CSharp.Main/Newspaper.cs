﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    //slightly modified in order to inherit from LibraryItem
    public class Newspaper : LibraryItem
    {
        public Newspaper(string title) : base(title)
        {

        }

        public override string checkIn() {
            return "newspapers are not available for loan";
        }

        public override string checkOut() {
            return "newspapers are not available for loan";
        }
    }
}
