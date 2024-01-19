using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        private Author _author;

        [SetUp]
        public void SetUp()
        {
            _author = new Author("TestName", "SomeContactInfo", "SomeURl");
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks", _author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks", _author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks", _author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks", _author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void testHasAuthorWithCorrectProperties()
        {
            //setup
            Article article = new("YEP", _author);

            //execute
            Author a = article.Author;

            //verify
            Assert.That(a, Is.Not.Null);
            Assert.That(a.Name, Is.EqualTo(_author.Name));
            Assert.That(a.ContactInfo, Is.EqualTo(_author.ContactInfo));
            Assert.That(a.WebsiteUrl, Is.EqualTo(_author.WebsiteUrl));
        }
    }
}