using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main.Author
{
    public interface IAuthor
    {
        public string name { get; set; }
        public string contactInfo { get; set; }
        public string website { get; set; }

    }
}
