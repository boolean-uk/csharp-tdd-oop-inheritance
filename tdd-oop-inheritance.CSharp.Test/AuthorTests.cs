using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;


namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class AuthorTests
    {
        [Test]
        public void AuthorPropertiesAreSetCorrectly()
        {
            var author = new Author("J.K. Rowling", "contact@jkrowling.com", "https://www.jkrowling.com/");
            Assert.AreEqual("J.K. Rowling", author.Name);
            Assert.AreEqual("contact@jkrowling.com", author.ContactInfo);
            Assert.AreEqual("https://www.jkrowling.com/", author.Website);
        }
        [Test]
        public void AuthorWithoutWebsitePropertiesAreSetCorrectly()
        {
            var author = new Author("J.K. Rowling", "contact@jkrowling.com", null);
            Assert.AreEqual("J.K. Rowling", author.Name);
            Assert.AreEqual("contact@jkrowling.com", author.ContactInfo);
            Assert.IsNull(author.Website);
        }
    }
}
