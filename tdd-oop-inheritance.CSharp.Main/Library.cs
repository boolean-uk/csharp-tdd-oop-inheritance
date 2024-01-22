using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Core;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library
    {
        List<Item> items = new List<Item>();

        public void AddToStock(Item item)
        {
            this.items.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string CheckInItem(string title)
        {
            List<Article> filtered = (List<Article>)this.items.Where(article => article.title.Equals(title));

            if (filtered.Count() == 0)
                return "item is not part of the library's collection";

            return filtered[0].CheckIn();
        }

        public string CheckOutItem(string title)
        {
            List<Article> filtered = (List<Article>)this.items.Where(article => article.title.Equals(title));

            if (filtered.Count() == 0)
                return "item is not part of the library's collection";

            return filtered[0].CheckOut();
        }
    }
}
