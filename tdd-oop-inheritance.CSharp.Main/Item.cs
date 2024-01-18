namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class Item
    {
        public string Title { get; }
        public bool onLoan;

        protected Item(string title)
        {
            Title = title;
            onLoan = false;
        }

        public abstract bool isOnLoan();

        public abstract string checkIn();

        public abstract string checkOut();

    }
}
