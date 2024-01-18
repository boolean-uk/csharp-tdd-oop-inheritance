namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class LibraryItem
    {
        public string Title { get; private set; }
        protected bool OnLoan { get; set; }

        protected LibraryItem(string title)
        {
            Title = title;
        }

        public abstract string CheckIn();
        public abstract string CheckOut();
    }
}
