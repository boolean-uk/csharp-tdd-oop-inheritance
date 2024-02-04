using NUnit.Framework;
using Items;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        private Newspaper newspaper;
        [SetUp]
        public void SetUp() 
        {
            newspaper = new Newspaper("The Daily Java");

        }
        [Test]
        public void ShouldBeUnavailableForCheckIn()
        {
            Assert.That(newspaper.CheckIn(), Is.EqualTo("Newspapers are not available for loan"));
        }

        [Test]
        public void ShouldBeUnavailableForCheckOut()
        {
            Assert.That(newspaper.CheckOut(), Is.EqualTo("Newspapers are not available for loan"));
        }
    }
}