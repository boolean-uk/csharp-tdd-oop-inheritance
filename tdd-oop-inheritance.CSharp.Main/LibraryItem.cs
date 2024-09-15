using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.oop.inheritance.CSharp.Main
{
    public abstract class LibraryItem
    {
        public string title;
        public bool onLoan;

        public LibraryItem(string title)
        {
            this.title = title;
        }
        public virtual bool IsOnLoan()
        {
            return onLoan;
        }
        public abstract string CheckIn();
        public abstract string CheckOut();
    }
}
