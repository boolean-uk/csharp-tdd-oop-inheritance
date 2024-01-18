

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class LibraryItem {
            public string title;

            protected bool onLoan = false;

            public LibraryItem(string title) {
                this.title = title;
            }
            
            public bool isOnLoan()  {
                return onLoan;
            }

            public virtual string checkIn() {
                if (!this.isOnLoan()) {
                    return "item is not currently on loan";
                }

                this.onLoan = false;

                return "item has been checked in";
            }

            public virtual string checkOut() {
                if (this.isOnLoan()) {
                    return "item is currently on loan";
                }

                this.onLoan = true;

                return "item has been checked out";
            }
    }
}