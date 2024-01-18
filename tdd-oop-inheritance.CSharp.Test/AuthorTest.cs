using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    internal class AuthorTest
{

        [Test]

        public void CanCreateAuthor()
        {
            Author author = new Author("AuthorName", "email@web.com","www.web.com");

            Assert.IsNotNull(author);
            string expectedResult = "Written by: AuthorName, reached at email@web.com, more books at www.web.com ";
            Assert.That(author.GetAuthorInfo(), Is.EqualTo(expectedResult));

        }
}
}
