using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {

        Author author;
        [SetUp]
        public void SetUp()
        {
            author = new Author("Henrik Rosenkilde", "henrik.rosenkilde@hotmail.com", "henrikrosenkilde.no");
        }

        [Test]

        public void TestIfAuthor() 
        {
            Book book = new Book("Junit Rocks", author);
            Assert.That(book.Author.Name, Is.EqualTo("Henrik Rosenkilde"));
            Assert.That(book.Author.ContactInfo, Is.EqualTo("henrik.rosenkilde@hotmail.com"));
            Assert.That(book.Author.Website, Is.EqualTo("henrikrosenkilde.no"));
        }

        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Article article = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}