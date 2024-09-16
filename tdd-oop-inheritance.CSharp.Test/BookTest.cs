using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldGetAuthorName()
        {
            Book book = new Book("Programming C# 8.0", new Author("Ian Griffiths", "ian.griffiths@maths.ox.ac.uk", "Professor of Industrial Mathematics based in the Mathematical Institute at the University of Oxford", "https://people.maths.ox.ac.uk/griffit4"));

            Assert.AreEqual("Ian Griffiths", book.AuthorName);
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("Programming C# 8.0", new Author("Ian Griffiths", "ian.griffiths@maths.ox.ac.uk", "Professor of Industrial Mathematics based in the Mathematical Institute at the University of Oxford", "https://people.maths.ox.ac.uk/griffit4"));
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("Programming C# 8.0", new Author("Ian Griffiths", "ian.griffiths@maths.ox.ac.uk", "Professor of Industrial Mathematics based in the Mathematical Institute at the University of Oxford", "https://people.maths.ox.ac.uk/griffit4"));
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("Programming C# 8.0", new Author("Ian Griffiths", "ian.griffiths@maths.ox.ac.uk", "Professor of Industrial Mathematics based in the Mathematical Institute at the University of Oxford", "https://people.maths.ox.ac.uk/griffit4"));
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("Programming C# 8.0", new Author("Ian Griffiths", "ian.griffiths@maths.ox.ac.uk", "Professor of Industrial Mathematics based in the Mathematical Institute at the University of Oxford", "https://people.maths.ox.ac.uk/griffit4"));

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}