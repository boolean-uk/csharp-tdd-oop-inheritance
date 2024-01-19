using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Readable {

        private Author author;
        public bool hasAuthor;
        public Article(string title, Author atuhor = null) : base(title) {
            onLoan = false;
            this.author = atuhor;
            if (author != null)
            {
                hasAuthor = true;    
            }
        }

        public Author Author { get { return author; } }

        public override bool isOnLoan()  {
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


    }
}
