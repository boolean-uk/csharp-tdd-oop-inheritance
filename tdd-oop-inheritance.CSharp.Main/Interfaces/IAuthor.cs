using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main.Interfaces
{
    public interface IAuthor
    {
        public string Name { get; }
        public string ContactInfo { get; set; }
        public string Website { get; set; }
    }
}
