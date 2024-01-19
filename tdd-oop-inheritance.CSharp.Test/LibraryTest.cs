using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void shouldBeAddedToStock()
        {
            Author author = new Author("Kristian", "Contact Info", "Website");
            Library library = new Library();
            Item item = new Book("Cool book", author);

            library.addToStock(item);

            Assert.That(library.Items.Count, Is.EqualTo(1));
        }

        [Test]
        public void shouldBeCheckedOut()
        {
            Author author = new Author("Kristian", "Contact Info", "Website");
            Library library = new Library();
            Item item = new Book("Cool book", author);

            library.addToStock(item);

            library.checkOutItem(item.title);

            Assert.That(item.isOnLoan(), Is.True);
        }

        [Test]
        public void shouldBeCheckedIn()
        {
            Author author = new Author("Kristian", "Contact Info", "Website");
            Library library = new Library();
            Item item = new Article("Cool article", author);

            library.addToStock(item);
            library.checkOutItem(item.title);
            library.checkInItem(item.title);

            Assert.That(item.isOnLoan(), Is.False);
        }

        [Test]
        public void shouldNotLoanNewspaper()
        {
            Library library = new Library();
            Item item = new Newspaper("Cool newspaper");

            library.addToStock(item);

            Assert.That(library.checkOutItem(item.title), Is.EqualTo("newspapers are not available for loan"));
        }

        [Test]
        public void shouldNotBeInStock()
        {
            Library library = new Library();
            Item item = new Item("Cool item");

            Assert.That(library.checkOutItem(item.title), Is.EqualTo("item is not part of the library's collection"));
        }
    }
}
