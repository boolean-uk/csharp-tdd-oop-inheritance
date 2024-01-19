using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;
using tdd_oop_inheritance.CSharp.Main.Objects;

namespace Objects
{
    public class Article : Publication
    {
        public Author _author;
        public Article(Author author)
        {
            this._author = author;
        }
        /*public string title;

        bool onLoan = false;

        public Article(string title)
        {
            this.title = title;
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public string checkIn()
        {
            if (!isOnLoan())
            {
                return "item is not currently on loan";
            }

            onLoan = false;

            return "item has been checked in";
        }

        public string checkOut()
        {
            if (isOnLoan())
            {
                return "item is currently on loan";
            }

            onLoan = true;

            return "item has been checked out";
        }*/

    }
}
