using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library
    {
        private List<ItemOfLibrary> items = new List<ItemOfLibrary>();
        public IReadOnlyList<ItemOfLibrary> Items => items.AsReadOnly();
        public void addToStock(ItemOfLibrary item)
        {
            this.items.Add(item);
        }
        public string checkInItem(string title)
        {
            var item = this.items.FirstOrDefault(i => i.title.Equals(title));

            if (item == null)
            {
                return "item is not part of the library's collection";
            }

            return item.checkIn();
        }
        public string checkOutItem(string title)
        {
            var item = this.items.FirstOrDefault(i => i.title.Equals(title));

            if (item == null)
            {
                return "item is not part of the library's collection";
            }
            return item.checkOut();
        }
    }
}