namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Item
    {
        //private bool onLoan = false;

        public Book(string title) : base(title)
        {

        }

        public override bool isOnLoan()
        {
            return onLoan;
        }

        public override string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public override string checkOut()
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
