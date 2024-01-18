using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void CheckItems()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Book book = new Book("Throne of Glass", "Sarah Maas", "sarah.j.maas@telia.com", "sarahMaasBooks.com");
            Article article = new Article("CandyHouse", "Jake Jones", "jones@telia.com", "jonesBooks.com");
            
            Library library = new Library();
            library.AddItems(newspaper);
            library.AddItems(book);
            library.AddItems(article);

            Assert.AreEqual(3, library.GetItems());
        }

        [Test]
        public void ShouldBeCheckedIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Book book = new Book("Throne of Glass", "Sarah Maas", "sarah.j.maas@telia.com", "sarahMaasBooks.com");
            Article article = new Article("CandyHouse", "Jake Jones", "jones@telia.com", "jonesBooks.com");

            Library library = new Library();
            library.AddItems(newspaper);
            library.AddItems(book);
            library.AddItems(article);

            Assert.AreEqual("item has been checked out", library.checkOutItem("Throne of Glass"));
        }
    }
}