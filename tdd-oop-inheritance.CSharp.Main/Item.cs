using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class Item
    {
        public string title;

        public bool onLoan = false;

        public Item(string title)
        {
            this.title = title;
        }

        public virtual bool isOnLoan()
        {
            return onLoan;
        }
        public abstract string checkIn();
        public abstract string checkOut();

    }
}
