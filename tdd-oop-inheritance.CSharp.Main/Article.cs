using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tdd_oop_inheritance.CSharp.Main.Interfaces;
namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Text, IAuthorable {

        private IAuthor _author;
        public bool authorExists;

        public Article(string title, IAuthor author) : base(title)
        {
            onLoan = false;
            _author = author;
            if (author != null)
            {
                authorExists = true;
            }
        }
        public IAuthor Author { get { return _author; } set { _author = value; } }

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
