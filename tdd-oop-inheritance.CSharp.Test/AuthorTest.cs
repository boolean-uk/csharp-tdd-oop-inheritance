using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class AuthorTest
    {
        [Test]
        public void getAuthorName()
        {
            //arrange
            IAuthor author = new Author("J. R. R Tolkien", "tolkien.email.com", "tolkien.com");

            //act
            string result = author.Name;

            //assert
            Assert.AreEqual("J. R. R Tolkien", result);
            

        }

        [Test]
        public void setAuthorName()
        {
            //arrange
            IAuthor author = new Author("J. R. R Tolkien", "tolkien.email.com", "tolkien.com");

            //act
            author.Name = "Test name";

            //assert
            Assert.AreEqual("Test name", author.Name);


        }



    }
}
