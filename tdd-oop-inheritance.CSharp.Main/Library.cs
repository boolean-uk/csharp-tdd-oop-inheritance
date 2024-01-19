using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library
    {

        
        

            List<Item> items = new List<Item>();


            public void addToStock(Item item)
            {
                this.items.Add(item);
            }


            public string checkInItem(string title)
            {

                Item item = items.FirstOrDefault(i => i.title.Equals(title));

                if (item == null)
                {
                    return "item is not part of the library's collection";
                }
                return item.checkIn();

            }

            public string checkOutItem(string title)
            {
                Item item = items.FirstOrDefault(i => i.title.Equals(title));
                if (item == null)
                {
                    return "item is not part of the library's collection";
                }
                return item.checkOut();

            }
        }
    
}
