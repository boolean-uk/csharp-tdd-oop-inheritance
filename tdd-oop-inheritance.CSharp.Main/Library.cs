using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {

        public List<Library> items = new List<Library>();
        protected string name = "";
        protected bool onLoan = false;

        public bool isOnLoan()
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

        public void addToStock(Library item) {
            this.items.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)

        public string checkInItem(string title)
        {
            List<Library> filtered = new List<Library>();

            foreach (Library item in this.items)
            {
                if (item.name == title)
                    filtered.Add(item);
            }

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutItem(string title) {

            List<Library> filtered = new List<Library>();

            foreach (Library item in this.items)
            {
                if (item.name == title)
                    filtered.Add(item);
            }

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
