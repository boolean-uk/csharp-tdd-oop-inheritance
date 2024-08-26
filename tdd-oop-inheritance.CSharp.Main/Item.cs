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
        public bool onLoan;

        protected Item(string title, bool onLoan)
        {
            this.title = title;
            this.onLoan = onLoan;
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public abstract string checkIn();

        public abstract string checkOut();
    }
}
