using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Library library = new Library();
            library.addToStock(newspaper);
            Assert.AreEqual("newspapers are not available for loan", library.checkInNewspaper("The Daily Java"));
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Library library = new Library();
            library.addToStock(newspaper);
            Assert.AreEqual("item has been checked out", library.checkOutNewspaper("The Daily Java"));
        }
    }
}