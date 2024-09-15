using Interface.oop.inheritance.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd.oop.inheritance.CSharp.Main.Interface;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Book : LibraryItem, IAuthorable
    {
        IAuthor _author;
        public Book(string title, IAuthor author) : base(title)
        {
            _author = author;
        }


        public override string CheckIn()
        {
            if (!IsOnLoan())
            {
                return "item is not currently on loan";
            }

            onLoan = false;

            return "item has been checked in";
        }

        public override string CheckOut()
        {
            if (IsOnLoan())
            {
                return "item is currently on loan";
            }

            onLoan = true;

            return "item has been checked out";
        }
        public IAuthor Author { get { return _author; } set { value = _author; } }
    }
}
