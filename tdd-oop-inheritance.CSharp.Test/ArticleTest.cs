using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class ArticleTest
    {
        private Author _author;
        private Article _article;

        [SetUp]
        public void Setup()
        {
            _author = new Author("Jane Doe" , "janedoe@example.com" , "www.janedoe.com");
            _article = new Article("An Interesting Article" , _author);
        }

        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            Assert.AreEqual("item has been checked out" , _article.CheckOut());
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            _article.CheckOut();
            Assert.AreEqual("item is currently on loan" , _article.CheckOut());
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            _article.CheckOut();
            Assert.AreEqual("item has been checked in" , _article.CheckIn());
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            Assert.AreEqual("item is not currently on loan" , _article.CheckIn());
        }

        [Test]
        public void ShouldHaveCorrectAuthor()
        {
            Assert.AreEqual(_author , _article.Author);
        }
    }
}