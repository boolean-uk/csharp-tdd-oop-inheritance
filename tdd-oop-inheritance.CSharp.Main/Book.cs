namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryItem
    {
        public Author Author { get; private set; }

        public Book(string title , Author author) : base(title)
        {
            Author = author;
        }

        public override string CheckIn()
        {
            if(!OnLoan)
            {
                return "item is not currently on loan";
            }

            OnLoan = false;
            return "item has been checked in";
        }

        public override string CheckOut()
        {
            if(OnLoan)
            {
                return "item is currently on loan";
            }

            OnLoan = true;
            return "item has been checked out";
        }
    }
}