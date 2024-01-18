namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library
    {
        List<Item> items = new List<Item>();

        public void addToStock(Item item)
        {
            this.items.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)

        public string CheckInItem(string title)
        {
            List<Item> filtered = new List<Item>();
            foreach (Item item in this.items)
            {
                if (item.Title.Equals(title))
                {
                    filtered.Add(item);
                }
            }
            //List<Item> filtered = (List<Item>)this.items.Where(item => item.Title.Equals(title));

            if (filtered.Count < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string CheckOutItem(string title)
        {
            List<Item> filtered = new List<Item>();
            foreach (Item item in this.items)
            {
                if (item.Title.Equals(title))
                {
                    filtered.Add(item);
                }
            }

            if (filtered.Count < 1)
            {
                return "item is not part of the library's collection";
            }
            return filtered[0].checkOut();
        }
    }
}
