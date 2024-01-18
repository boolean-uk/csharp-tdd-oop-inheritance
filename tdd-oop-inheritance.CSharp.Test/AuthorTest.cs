using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class AuthorTest
    {
        private Author _author;

        [SetUp]
        public void Setup()
        {
            _author = new Author("John Doe" , "johndoe@example.com" , "www.johndoe.com");
        }

        [Test]
        public void ShouldHaveCorrectName()
        {
            Assert.AreEqual("John Doe" , _author.Name);
        }

        [Test]
        public void ShouldHaveCorrectContactInfo()
        {
            Assert.AreEqual("johndoe@example.com" , _author.ContactInfo);
        }

        [Test]
        public void ShouldHaveCorrectWebsite()
        {
            Assert.AreEqual("www.johndoe.com" , _author.Website);
        }
    }

}
