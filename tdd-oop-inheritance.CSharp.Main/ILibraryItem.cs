using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public interface ILibraryItem
    {
        public string Title { get; }

        public bool OnLoan { get; set; }
        public string checkIn();
        public string checkOut();
    }
}
