using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interfaces;

namespace tdd_oop_inheritance.CSharp.Main.Parentclass
{
    public class Literature
    {
        public string title;
        public IAuthor author;

        bool onLoan = false;

        public Literature(string title, IAuthor? author = null)
        {
            this.title = title;
            if (author != null)
            {
                this.author = author;
            }
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public virtual string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public virtual string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }

        public string getAuthorName()
        {
            if (author == null)
            {
                return $"This {GetType().Name.ToLower()} has no author, or multiple.";
            }

            return author.Name;
        }

        public string getAuthorContactInformation()
        {
            if (author == null)
            {
                return $"This {GetType().Name.ToLower()} has no author, or multiple.";
            }

            return author.ContactInformation;
        }

        public string getAuthorWebsite()
        {
            if (author == null)
            {
                return $"This {GetType().Name.ToLower()} has no author, or multiple.";
            }

            return author.Website;
        }
    }
}
