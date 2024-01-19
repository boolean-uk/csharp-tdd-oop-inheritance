using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : Readables
    {
        //public string title;

        //Boolean onLoan = false;

        public Newspaper(string title, Author author = null) : base(title, author)
        {
            loanable = false;
        }

        //public bool isOnLoan() {
        //    return onLoan;
        //}

        //public string checkIn() {
        //    return "newspapers are not available for loan";
        //}

        //public string checkOut() {
        //    return "newspapers are not available for loan";
        //}
    }
}
