using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItems
{
    public class Newspaper : LibraryItem
    {
        public Newspaper(string title) : base(title)
        {
        }

        public override string CheckIn()
        {
            return "newspapers are not available for loan";
        }

        public override string CheckOut()
        {
            return "newspapers are not available for loan";
        }
    }
}
