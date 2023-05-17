using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace Items
{
    public class Book : LibaryItem
    {
        public Book(string title) : base(title)
        {
        }
    }
}
