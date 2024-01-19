using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public interface IAuthor
    {
        public string name { get; set; }
        public string contactinfo { get; set; }
        public string website { get; set; }
    }
}
