namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LibraryItem
    {
        public Newspaper(string title) : base(title) { }

        public override string CheckIn()
        {
            return "newspapers are not available for loan";
        }

        public override string CheckOut()
        {
            return "newspapers are not available for loan";
        }
    }
}