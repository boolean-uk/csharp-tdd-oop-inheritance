using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Article article = new Article("JUnit Rocks");
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void authorShouldBeJohn()
        {
            Article article = new Article(new Author("John Nilsson", "attsjö", "john.com"), "Machine Learning");
            Assert.AreEqual("John Nilsson", article.author.Name);
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Article article = new Article("JUnit Rocks");
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void BookshouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }


        [Test]
        public void ArticleshouldDeclineCheckInIfNotOnLoan()
        {
            Article article = new Article("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }

        [Test]
        public void NewspapershouldBeUnavailableForCheckIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void NewspapershouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }

    }
}