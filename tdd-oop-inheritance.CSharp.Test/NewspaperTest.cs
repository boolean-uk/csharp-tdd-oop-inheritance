using NUnit.Framework;
using LibraryItems;

namespace tdd.oop.inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void ShouldBeUnavailableForCheckIn()
        {
            Newspaper newspaper = new("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.CheckIn());
        }

        [Test]
        public void ShouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.CheckOut());
        }
    }
}