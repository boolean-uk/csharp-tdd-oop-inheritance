using Interface.oop.inheritance.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.oop.inheritance.CSharp.Main
{
    public class Author : IAuthor
    {
        public string Name { get; set; }
        public string ContactInformation { get; set; }
        public string website { get; set; }
    }
}
