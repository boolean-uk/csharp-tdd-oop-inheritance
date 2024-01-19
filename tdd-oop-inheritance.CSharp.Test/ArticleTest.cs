using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
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
            Article article = new Article("JUnit Rocks", _author);
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Article article = new Article("JUnit Rocks", _author);
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Article article = new Article("JUnit Rocks", _author);
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Article article = new Article("JUnit Rocks", _author);

            Assert.AreEqual("item is not currently on loan", article.checkIn());
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