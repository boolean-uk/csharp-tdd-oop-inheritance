using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author(string name, string phoneNumber, string website)
    {
        public string Name { get; } = name;
        public string PhoneNumber { get; } = phoneNumber;
        public string Website { get; } = website;
    }
}
