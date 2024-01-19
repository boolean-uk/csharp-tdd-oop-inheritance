﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Readable {

        Author author;
        public bool hasAuthor;

        public Book(string title, Author author = null) : base(title) {
            this.title = title;
            this.author = author;
            if (author != null)
            {
                hasAuthor = true;
            }
            onLoan = false;
        }

        public override bool isOnLoan() {
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
