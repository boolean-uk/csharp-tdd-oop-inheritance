﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class ItemOfLibrary
    {
        public string title;
        protected bool onLoan = false;
        public ItemOfLibrary(string title)
        {
            this.title = title;
        }
        public virtual bool isOnLoan()
        {
            return onLoan;
        }
        public virtual string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.onLoan = false;
            return "item has been checked in";
        }
        public virtual string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }
            this.onLoan = true;
            return "item has been checked out";
        }
    }
}