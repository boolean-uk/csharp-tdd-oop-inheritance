using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class Paper
    {
        protected string _title;
        protected bool _onLoan = false;

        protected Paper(string title)
        {
            _title = title;
        }

        public bool isOnLoan()
        {
            return _onLoan;
        }

        public string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "Item is not currently on loan";
            }

            _onLoan = false;

            return "item has been checked in";
        }

        public string checkOut()
        {
            if (this.isOnLoan())
            {
                return "Item is currently on loan";
            }

            _onLoan = true;

            return "item has been checked out";
        }
    }
}
