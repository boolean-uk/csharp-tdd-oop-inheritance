using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Stock, Author
    {
        public string name { get ; set ; }
        public string contact_info { get; set; }
        public string website { get; set; }

        public Article(string title, string name, string contact_info, string website)
        {
            this.title = title;
            this.name = name;
            this.contact_info = contact_info;
            this.website = website;
        }

    }
}
