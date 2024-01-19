using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks",bob);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);
            article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);
            article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);

            Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
        [Test]
        public void getAuthorInfoFromBook()
        {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);


            Assert.AreEqual(article.getAuthorInfo()[0], "Bobby Wills");
            Assert.AreEqual(article.getAuthorInfo()[1], "Bobby@Wills.com");
            Assert.AreEqual(article.getAuthorInfo()[2], "BobbyWills.com");


        }
    }
}