using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");
            Article article = new Article("JUnit Rocks", testAuthor);
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");

            Article article = new Article("JUnit Rocks", testAuthor);
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");

            Article article = new Article("JUnit Rocks", testAuthor);
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");

            Article article = new Article("JUnit Rocks", testAuthor);

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }
        [Test]
        public void shouldHaveAuthor()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");
            Article article = new Article("JUnit Rocks", testAuthor);
            Assert.AreEqual(testAuthor, article.author);
        }
    }
}