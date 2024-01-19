using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        Newspaper newspaper;
        Library library;

        [SetUp]
        public void SetUp()
        {
            newspaper = new("The Daily Java");
            library = new();
            library.addToStock(newspaper);
        }

        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Assert.That(library.checkInItem(newspaper.title), Is.EqualTo("newspapers are not available for loan"));
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Assert.That(library.checkOutItem(newspaper.title), Is.EqualTo("newspapers are not available for loan"));
        }
    }
}