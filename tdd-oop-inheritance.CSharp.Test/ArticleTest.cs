using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {

        Article article;
        Library library;
        Author author;

        [SetUp]
        public void SetUp()
        {
            author = new("John", "john@mail.com", "john.com");
            article = new("JUnit Rocks", author);
            library = new();
            library.addToStock(article);
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Assert.That(library.checkOutItem(article.title), Is.EqualTo("item has been checked out"));
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            library.checkOutItem(article.title);
            Assert.That(library.checkOutItem(article.title), Is.EqualTo("item is currently on loan"));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            library.checkOutItem(article.title);
            Assert.That(library.checkInItem(article.title), Is.EqualTo("item has been checked in"));
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Assert.That(library.checkInItem(article.title), Is.EqualTo("item is not currently on loan"));
        }

        [Test]
        public void hasAuthorName() 
        {
            Assert.That(library.getAuthor(article.title).name, Is.EqualTo(author.name));
        }
    }
}