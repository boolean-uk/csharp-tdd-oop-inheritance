using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Article article = new Article("JUnit Rocks");
                Library library = new Library();
                library.addToStock(article);
                string result = library.checkOutArticle("JUnit Rocks");
                string expected = "item has been checked out";


                Assert.AreEqual(expected,result );
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new Article("JUnit Rocks");
                Library library = new Library();    
                library.addToStock(article);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", library.checkOutArticle("JUnit Rocks"));
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Article article = new Article("JUnit Rocks");
                Library library = new Library();
                library.addToStock(article);
                article.checkOut();

                Assert.AreEqual("item has been checked in", library.checkInArticle("JUnit Rocks"));
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new Article("JUnit Rocks");
                Library library = new Library();
                library.addToStock(article);

            Assert.AreEqual("item is not currently on loan", library.checkInArticle("JUnit Rocks"));
            }
    }
}