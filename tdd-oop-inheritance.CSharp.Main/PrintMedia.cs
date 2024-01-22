using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class PrintMedia
    {
        private string title;
        private bool onLoan;

        public PrintMedia(string title)
        {
            this.title = title;
        }

        public string Title { get => title; set => title = value; }
        public bool OnLoan { get => onLoan; set => onLoan = value; }
    }
}
