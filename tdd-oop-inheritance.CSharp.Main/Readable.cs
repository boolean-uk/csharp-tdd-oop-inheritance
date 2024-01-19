using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class Readable
    {
        protected string title;
        protected bool onLoan;

        public Readable(string title)
        {
            this.title = title;
            onLoan = false;
        }

        public abstract string checkIn();
        public abstract string checkOut();
        public abstract bool isOnLoan();
    }
}
