using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class ReadableItem {
        
        protected string? Title;
        protected bool onLoan = false;

        public bool isOnLoan() {
            return onLoan;
        }

        public virtual string checkIn() {
            if (!isOnLoan()) {
                return "item is not currently on loan";
            }
            onLoan = false;
            return "item has been checked in";
        }

        public virtual string checkOut() {
            if (isOnLoan()) {
                return "item is currently on loan";
            }
            onLoan = true;
            return "item has been checked out";
        }

        public string? getTitle() {
            return Title;
        }

        // Exercise 2
        public virtual string getInformation() {
            return $"Title: {Title}, On Loan: {onLoan}";
        }
    }
}