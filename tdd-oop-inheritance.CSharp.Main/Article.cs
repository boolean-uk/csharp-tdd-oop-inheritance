using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : ReadingMaterial{
        //public string title;

        bool onLoan = false;

        public Article(string title, bool onLoan) : base(title, onLoan) 
        {
            //this.title = title;
        }
        
        //public new bool isOnLoan()  {
        //    return onLoan;
        //}

        //public new string checkIn() {
        //    if (!this.isOnLoan()) {
        //        return "item is not currently on loan";
        //    }

        //    this.onLoan = false;

        //    return "item has been checked in";
        //}

        //public new string checkOut() {
        //    if (this.isOnLoan()) {
        //        return "item is currently on loan";
        //    }

        //    this.onLoan = true;

        //    return "item has been checked out";
        //}
    }
}
