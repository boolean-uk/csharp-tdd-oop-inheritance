namespace tdd_oop_inheritance.CSharp.Main
{
    public class LibraryItem
    {
        public string title;

        bool onLoan = false;

        public LibraryItem(string title)
        {
            this.title = title;
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }
    }
}
