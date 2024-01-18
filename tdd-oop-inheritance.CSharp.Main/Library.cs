using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<Item> items = new List<Item>();

        public void addToStock(Item item)
        {
            this.items.Add(item);
        }

        public string checkInItem(string title)
        {
            IEnumerable<Item> filtered = items.Where(item => item.title.Equals(title));
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered.First().checkIn();
        }

        public string checkOutItem(string title)
        {
            IEnumerable<Item> filtered = items.Where(item => item.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered.First().checkOut();
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
    }
}
