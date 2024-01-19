using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test;

public class LibraryTests
{
    [Test]
    public void shouldCheckOutIfAvailable()
    {
        Library library = new Library();
        Book book = new Book("JUnit Rocks");
        library.addToStock(book);

        Assert.AreEqual("item has been checked out", library.checkOutProduct("JUnit Rocks"));
    }

    [Test]
    public void shouldDeclineIfNotAvailableToCheckout()
    {
        Library library = new Library();
        Book book = new Book("JUnit Rocks");
        library.addToStock(book);
        library.checkOutProduct("JUnit Rocks");

        Assert.AreEqual("item is currently on loan", library.checkOutProduct("JUnit Rocks"));
    }

    [Test]
    public void shouldCheckInIfOnLoan()
    {
        Library library = new Library();
        Book book = new Book("JUnit Rocks");
        library.addToStock(book);
        library.checkOutProduct("JUnit Rocks");

        Assert.AreEqual("item has been checked in", library.checkInProduct("JUnit Rocks"));
    }

    [Test]
    public void shouldDeclineCheckInIfNotOnLoan()
    {
        Library library = new Library();
        Book book = new Book("JUnit Rocks");
        library.addToStock(book);

        Assert.AreEqual("item is not currently on loan", library.checkInProduct("JUnit Rocks"));
    }
}