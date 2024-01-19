using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Readables
    {
        //public string title;

        //bool onLoan = false;

        public Book(string title, Author author = null) : base(title, author)
        {
        }

        //public bool isOnLoan() {
        //    return onLoan;
        //}

        //public string checkIn() {
        //    if (!this.isOnLoan()) {
        //        return "item is not currently on loan";
        //    }

        //    this.onLoan = false;

        //    return "item has been checked in";
        //}

        //public string checkOut() {
        //    if (this.isOnLoan()) {
        //        return "item is currently on loan";
        //    }

        //    this.onLoan = true;

        //    return "item has been checked out";
        //}
    }
}
