using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library
    {
        List<Literature> literatureList = new List<Literature>();

        public void addToStock(Literature item)
        {
            this.literatureList.Add(item);
        }

        public string checkIn(string title)
        {
            List<Literature> filtered = this.literatureList.Where(literature => literature._title.Equals(title)).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }


        public string checkOut(string title)
        {
            List<Literature> filtered = this.literatureList.Where(literature => literature._title.Equals(title)).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
