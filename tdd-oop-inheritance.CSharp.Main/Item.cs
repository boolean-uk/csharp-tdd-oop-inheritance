namespace tdd_oop_inheritance.CSharp.Main
{
    public class Item
    {
        public string Title { get; }
        private bool onLoan;

        protected Item(string title)
        {
            Title = title;
            onLoan = false;
        }

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
    }
}