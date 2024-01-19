using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Article article = new Article("JUnit Rocks", author);
                Assert.AreEqual("Item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("Item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("Item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Article article = new Article("JUnit Rocks", author);

                Assert.AreEqual("Item is not currently on loan", article.checkIn());
            }
    }
}