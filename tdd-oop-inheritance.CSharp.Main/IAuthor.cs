using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public interface IAuthor
    {
        void SetAuthor(string name, string number, string email);

        Author GetAuthor();


    }
}
