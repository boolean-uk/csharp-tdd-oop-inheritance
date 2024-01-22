using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_oop_inheritance.CSharp.Main.Interfaces
{
    public interface IAuthor
    {

        public string Name { get; set; }
        public string ContactInformation { get; set; }
        public string Website { get; set; } 

    }
}
