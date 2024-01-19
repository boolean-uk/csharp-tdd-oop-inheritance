namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper(string title) : LibraryItem(title)
    {
        public new string checkIn() //LibraryItem.checkOut would need to be marked as virtual if you want to use override
        {
            return "newspapers are not available for loan";
        }
        public new string checkOut() //LibraryItem.checkOut would need to be marked as virtual if you want to use override
        {
            return "newspapers are not available for loan";
        }
    }
}
