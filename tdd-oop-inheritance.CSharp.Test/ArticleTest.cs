using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        Author author = new Author("Steven Guy", "+4712345678", "http://thisisawebsite.com");

        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Literature article = new Article(author, "JUnit Rocks");
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Literature article = new Article(author, "JUnit Rocks");
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Literature article = new Article(author, "JUnit Rocks");
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Literature article = new Article(author, "JUnit Rocks");

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        [Test]
        public void shouldReturnNameOfAuthor()
        {
            Literature book = new Book(author, "JUnit Rocks");
            string nameOfAuthor = "";
            if (book is Book b) nameOfAuthor = b.Author.Name;
            Assert.AreEqual("Steven Guy", nameOfAuthor);
        }
    }
}