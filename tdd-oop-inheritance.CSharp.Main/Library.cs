using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library:InventoryItem
    {
        private Dictionary<int,Item> inventory = new Dictionary<int, Item>();

       
        public void addToStock(Item item) {
            this.inventory.Add(inventory.Count,item);
        }

        public string checkIn(Item item) {
            List<Item> filtered = new List<Item>();
            foreach (Item item2 in this.inventory.Values)
            {
                if (item2.Title.Equals(item.Title)) { filtered.Add(item2); }
            }
            
            


            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }


        public string checkOut(Item item)
        {
            List<Item> filtered = new List<Item>();
            foreach (Item item2 in this.inventory.Values)
            {
                if (item2.Title.Equals(item.Title)) { filtered.Add(item2); }
            }


            if (filtered.Count() < 1)
                {
                    return "item is not part of the library's collection";
                }

               return filtered[0].checkOut();
            }

        public Dictionary<int,Item> getInventory { get => inventory; }
        }
    }

