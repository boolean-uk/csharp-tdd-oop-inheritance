namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem
    {
        public Article(string title) : base(title) { }

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