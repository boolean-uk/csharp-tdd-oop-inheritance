using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Author author = new Author("Axel", "95901753", "www.com");
                ItemClass item = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", item.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass item = new Article("JUnit Rocks", author);
                item.checkOut();

                Assert.AreEqual("item is currently on loan", item.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        [Test]
        public void getAuthorForBook()
        {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass book = new Book("What", author);

            Assert.That(book.returnAuthor(), Is.EqualTo(author));

            
        }
    }
}