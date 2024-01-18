using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class LoanitemWithAuthor : LoanItem
    {
        protected Author author;
        public LoanitemWithAuthor(string title, Author author):base(title) {
            this.author = author;
        }

        public virtual string GetAuthor()
        {
            return author.GetAuthorInfo();
        }
    }
}
