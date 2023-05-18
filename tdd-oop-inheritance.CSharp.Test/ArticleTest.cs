using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main.Interface;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
            Author author = new Author("thanasis", "uk", "69999999");
            Article article = new Article("JUnit Rocks", author);
            Library library = new Library();
                article.addToStock(article);
                string result = article.checkOutArticle("JUnit Rocks");
                string expected = "item has been checked out";


                Assert.AreEqual(expected,result );
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Author author = new Author("thanasis", "uk", "69999999");
            Article article = new Article("JUnit Rocks", author);
            Library library = new Library();    
                article.addToStock(article);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOutArticle("JUnit Rocks"));
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Author author = new Author("thanasis", "uk", "69999999");
                Article article = new Article("JUnit Rocks", author);
                Library library = new Library();
                article.addToStock(article);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkInArticle("JUnit Rocks"));
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            Author author = new Author("thanasis", "uk", "69999999");
            Article article = new Article("JUnit Rocks", author);
            Library library = new Library();
                article.addToStock(article);

            Assert.AreEqual("item is not currently on loan", article.checkInArticle("JUnit Rocks"));
            }
    }
}