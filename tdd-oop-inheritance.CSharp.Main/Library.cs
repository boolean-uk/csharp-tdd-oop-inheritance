using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryItems;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<ILibraryItem> libraryItems = [];

        public void addToStock(ILibraryItem item)
        {
            libraryItems.Add(item);
        }

        public string checkIn(string title)
        {
            List<ILibraryItem> filtered = libraryItems.Where(x => x.Title.Equals(title)).ToList();

            if (filtered.Count < 1) 
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOut(string title)
        {
            List<ILibraryItem> filtered = libraryItems.Where(x => x.Title.Equals(title)).ToList();

            if (filtered.Count < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
