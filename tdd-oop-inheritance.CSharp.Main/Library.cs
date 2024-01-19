using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library 
    {

        private List<LibraryItem> items = new List<LibraryItem>();

        public void addToStock(LibraryItem item) 
        {
            this.items.Add(item);
        }
        public string checkIn(string title)
        {

            LibraryItem item = items.FirstOrDefault(x => x.title == title);

            if (item != null)
            {
                return item.checkIn();
            }
            return "item is not part of the library's collection";
        }

            public string checkOut(string title)
        {

            LibraryItem item = items.FirstOrDefault(x => x.title == title);

            if (item != null)
            {
                return item.checkOut();
            }

            return "item is not part of the library's collection";
    
        }
    }
}
