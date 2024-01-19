using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main.Core
{
    public abstract class Item
    {
        public string title;

        protected Boolean onLoan = false;

        public Item(string title)
        {
            this.title = title;
        }

        public bool IsOnLoan()
        {
            return onLoan;
        }

        public virtual string CheckIn()
        {
            if(!onLoan)
                return "item is not currently on loan";

            onLoan = false;
            return "item has been checked in";
        }

        public virtual string CheckOut()
        {
            if(onLoan)
                return "item is currently on loan";


            onLoan = true;
            return "item has been checked out";
        }
    }
}
