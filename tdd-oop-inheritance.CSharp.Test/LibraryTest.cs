using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        private Author author;
        private Article article;
        private Library library;
        private Book book;
        private Newspaper newspaper; 

        [SetUp]
        public void SetUp()
        {
            library = new Library();
            author = new Author("Dan Brown", "dan@brown.com", "www.danbrown.com");
            article = new Article("C# Fundamentals", author);
            book = new Book("C# Programming", author);
            newspaper = new Newspaper("C# for dummies");
        }

        [Test]
        public void ShouldAddArticleToStock()
        {
            library.AddToStock(article);
            Assert.That(library.items, Contains.Item(article));
        }

        [Test]
        public void ShouldAddBookToStock()
        {
            library.AddToStock(book);
            Assert.That(library.items, Contains.Item(book));
        }

        [Test]
        public void ShouldAddNewspaperToStock()
        {
            library.AddToStock(newspaper);
            Assert.That(library.items, Contains.Item(newspaper));
        }

        [Test]
        public void ShouldCheckInArticleIfOnLoan()
        {
            library.AddToStock(article);
            article.CheckOut();

            string result = library.CheckInOut<Article>("C# Fundamentals", false);
            Assert.That(result, Is.EqualTo("Item has been checked in"));
        }

        [Test]
        public void ShouldDeclineCheckInArticleIfNotOnLoan()
        {
            library.AddToStock(article);

            string result = library.CheckInOut<Article>("C# Fundamentals", false);
            Assert.That(result, Is.EqualTo("Item is not currently on loan"));
        }

        [Test]
        public void ShouldCheckOutBookIfAvailable()
        {
            library.AddToStock(book);

            string result = library.CheckInOut<Book>("C# Programming", true);
            Assert.That(result, Is.EqualTo("Item has been checked out"));
        }

        [Test]
        public void ShouldDeclineCheckOutBookIfNotAvailable()
        {
            library.AddToStock(book);
            book.CheckOut();

            string result = library.CheckInOut<Book>("C# Programming", true);
            Assert.That(result, Is.EqualTo("Item is currently on loan"));
        }
        
        [Test]
        public void ShouldBeUnavailableForCheckInNewspaper()
        {
            library.AddToStock(newspaper);

            string result = library.CheckInOut<Newspaper>("The Daily C#", true);
            Assert.That(result, Is.EqualTo("Newspapers are not available for loan"));

            result = library.CheckInOut<Newspaper>("The Daily C#", false);
            Assert.That(result, Is.EqualTo("Newspapers are not available for loan"));
        }
    }
}
