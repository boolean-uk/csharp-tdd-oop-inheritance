using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class AuthorTest
    {
        [Test]
        public void CanAddAuthor()
        {
            Library library = new Library();

            library.addToStock(new Article("JUnit Rocks!", new Author("Nigel", "nigel@boolean.com", "boolean.co.uk")));

            Assert.That("Nigel", Is.EqualTo(library.LibraryList[0].Author.AuthorName));

        }
    }
}
