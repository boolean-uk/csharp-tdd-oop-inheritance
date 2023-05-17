using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryItems;

namespace tdd.oop.inheritance.CSharp.Main
{
    public class Library
    {
        public List<LibraryItem> Items = new List<LibraryItem>();


        public void AddToStock(LibraryItem item)
        {
            this.Items.Add(item);
        }



        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string CheckInItem(string title)
        {

            List<LibraryItem> filtered = (List<LibraryItem>)this.Items.Where(item => item.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].CheckIn();
        }

        public string CheckOutItem(string title)
        {
            List<LibraryItem> filtered = (List<LibraryItem>)this.Items.Where(item => item.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].CheckOut();
        }


    }
}
