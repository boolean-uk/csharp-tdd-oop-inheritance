namespace Items
{
    public abstract class Item
    {
        public string Title { get; set; }
        public bool OnLoan { get; set; }

        public Item(string title)
        {
            Title = title;
        }

        public string CheckIn()
        {
            if (!OnLoan)
            {
                return "Item is not currently on loan";
            }

            OnLoan = false;
            return "Item has been checked in";
        }

        public string CheckOut()
        {
            if (OnLoan)
            {
                return "Item is currently on loan";
            }

            OnLoan = true;
            return "Item has been checked out";
        }
    }
}
