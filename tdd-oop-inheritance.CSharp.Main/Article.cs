namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Item
    {
        public Article(string title) : base(title) { }

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

            base.onLoan = false;

            return "item has been checked in";
        }

        public override string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            base.onLoan = true;

            return "item has been checked out";
        }
    }
}
