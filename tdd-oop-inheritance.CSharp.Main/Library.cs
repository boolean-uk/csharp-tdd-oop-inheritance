using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<Text> texts = new List<Text>();

        public void addToStock(Text item)
        {
            this.texts.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInText(Text text)
        {
            List<Text> filtered = (List<Text>)this.texts.Where(text => text.Equals(text));
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }
            return filtered[0].checkIn();
        }

        public string checkOutText(Text text)
        {
            List<Text> filtered = (List<Text>)this.texts.Where(text => text.Equals(text));
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }
            return filtered[0].checkOut();
        }
    }
}
