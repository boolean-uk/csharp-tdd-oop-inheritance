using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public interface Item 
    {
        public string Title { get; set; }

        public string checkIn() {
            return string.Empty;
        }
        public string checkOut()
        {
            return string.Empty;
        }
    }
}
