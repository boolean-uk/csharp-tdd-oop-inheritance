using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        private string _authorname;
        private string _authorwebsite;
        private string _authorcontact;

        public Author (string authorname, string authorwebsite, string authorcontact)
        {
            this._authorname = authorname;
            this._authorwebsite = authorwebsite;
            this._authorcontact = authorcontact;
        }

        public string AuthorName { get => _authorname; set => _authorname = value; }
        public string AuthorWebsite { get => _authorwebsite; set => _authorwebsite = value; }   
        public string AuthorContact { get => _authorcontact; set => _authorcontact = value; }       
    }
}
