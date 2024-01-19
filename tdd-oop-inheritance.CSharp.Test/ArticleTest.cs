using NUnit.Framework;
using Objects;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };

            Article article = new Article(author) { Title = "JUnit Rocks" };
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };

            Article article = new Article(author) { Title = "JUnit Rocks" };
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };

            Article article = new Article(author) { Title = "JUnit Rocks" };
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };

            Article article = new Article(author) { Title = "JUnit Rocks" };

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }
    }
}