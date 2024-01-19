using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
{
        Library library;

        [SetUp]
        public void SetUp()
        {
            library = new Library();
        }
        [Test]
        public void TryAddingToStock()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            string test = library.addToStock(newspaper);
            Assert.That(test, Is.EqualTo(new string("The Daily Java was added to the collection!")));
            Assert.That(library.literature.Count, Is.EqualTo(1));
        }
        [Test]
        public void TryAddingDubbleToStock()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            library.addToStock(newspaper);
            string test = library.addToStock(newspaper);
            Assert.That(test, Is.EqualTo(new string("The Daily Java has already been added to the collection in your library")));
        }

        [Test]
        public void ShouldBeUnavailableForCheckOut()
        {
            Author author = new Author("Henrik Rosenkilde", "henrik.rosenkilde@hotmail.com", "henrikrosenkilde.no");
            Newspaper newspaper = new Newspaper("The Daily Java");
            Book book = new Book("JUnit Rocks", author);
            Article article = new Article("JUnit Rocks", author);
            library.addToStock(newspaper);
            library.addToStock(book);
            library.addToStock(article);

            Assert.That(book.Author.Name, Is.EqualTo("Henrik Rosenkilde"));
            Assert.That(book.Author.ContactInfo, Is.EqualTo("henrik.rosenkilde@hotmail.com"));
            Assert.That(book.Author.Website, Is.EqualTo("henrikrosenkilde.no"));

            Assert.That(article.Author.Name, Is.EqualTo("Henrik Rosenkilde"));
            Assert.That(article.Author.ContactInfo, Is.EqualTo("henrik.rosenkilde@hotmail.com"));
            Assert.That(article.Author.Website, Is.EqualTo("henrikrosenkilde.no"));

            string test = library.checkOutLiterature("The Daily Java");
            Assert.That(test, Is.EqualTo("newspapers are not available for loan"));

            test = library.checkOutLiterature("JUnit Rocks");
            Assert.That(test, Is.EqualTo("item has been checked out"));

            test = library.checkOutLiterature("JUnit Rocks");
            Assert.That(test, Is.EqualTo("item is currently on loan"));


            test = library.checkInLiterature("JUnit Rocks");
            Assert.That(test, Is.EqualTo("item has been checked in"));

            test = library.checkInLiterature("JUnit Rocks");
            Assert.That(test, Is.EqualTo("item is not currently on loan"));

        }
    }
}
