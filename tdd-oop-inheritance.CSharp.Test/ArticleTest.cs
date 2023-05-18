using NUnit.Framework;
using Items;
using tdd_oop_inheritance.CSharp.Main.Author;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            { 
                IAuthor author = new Author() { name="Adam" };
                Article article = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                IAuthor author = new Author() { name="Dave" };
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                IAuthor author = new Author() { name="Nigel" };
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                IAuthor author = new Author() { name="Nikita" };
                Article article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}