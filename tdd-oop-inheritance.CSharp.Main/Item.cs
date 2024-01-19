using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Item
    {
        private string _title;
        private bool _onLoan;

        public string Title { get { return _title;  } }

        public Item(string title)
        {
            _title = title;
            _onLoan = false;
        }

        public bool isOnLoan() { return _onLoan; }

        public virtual string checkIn()
        {
            if (!isOnLoan())
            {
                return "item is not currently on loan";
            }

            _onLoan = false;

            return "item has been checked in";
        }

        public virtual string checkOut()
        {
            if (isOnLoan())
            {
                return "item is currently on loan";
            }

            _onLoan = true;

            return "item has been checked out";
        }
    }
}
