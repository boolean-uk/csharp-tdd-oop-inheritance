using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Material
    {
        //public string title;
        private Author author;
        bool onLoan = false;

        public Article(string title, Author author) : base(title)
        {
            //this.title = title;
            this.author = author;   
        }
        
        public bool isOnLoan()  
        {
            return onLoan;
        }

        public override string checkIn() {
            if (!this.isOnLoan()) {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public override string checkOut() {
            if (this.isOnLoan()) {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }
        public Author GetAuthor()
        {
            return author;
        }
    }
}
