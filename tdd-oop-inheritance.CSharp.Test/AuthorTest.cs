using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class AuthorTest
    {
        [Test]
        public void AuthorInitialization_ShouldSetPropertiesCorrectly()
        {
            string name = "John Doe";
            string contactInfo = "john@example.com";
            string website = "www.example.com";

            Author author = new Author(name, contactInfo, website);

            Assert.AreEqual(name, author.Name);
            Assert.AreEqual(contactInfo, author.ContactInformation);
            Assert.AreEqual(website, author.Website);
        }

        [Test]
        public void AuthorInformationRetrieval_ShouldReturnCorrectData()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");

            Assert.AreEqual("John Doe", author.Name);
            Assert.AreEqual("john@example.com", author.ContactInformation);
            Assert.AreEqual("www.example.com", author.Website);
        }
    }
}
