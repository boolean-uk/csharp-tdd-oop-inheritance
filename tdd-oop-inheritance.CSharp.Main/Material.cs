using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Material
    {
        private string title;
        private bool isOnLoan = false;

        public Material(string title)
        {
            this.title = title;
        }

        public bool IsOnLoan()
        {
            return isOnLoan;
        }

        public virtual string checkIn()
        {
            return "";
        }
        public virtual string checkOut()
        {
            return "";
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}