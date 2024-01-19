using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test;

public class LibraryTests
{
    [Test]
    public void shouldCheckOutIfAvailable()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Library library = new Library();
        Book book = new Book("JUnit Rocks", author);
        library.addToStock(book);

        Assert.AreEqual("item has been checked out", library.checkOutProduct("JUnit Rocks"));
    }

    [Test]
    public void shouldDeclineIfNotAvailableToCheckout()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Library library = new Library();
        Book book = new Book("JUnit Rocks", author);
        library.addToStock(book);
        library.checkOutProduct("JUnit Rocks");

        Assert.AreEqual("item is currently on loan", library.checkOutProduct("JUnit Rocks"));
    }

    [Test]
    public void shouldCheckInIfOnLoan()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Library library = new Library();
        Book book = new Book("JUnit Rocks", author);
        library.addToStock(book);
        library.checkOutProduct("JUnit Rocks");

        Assert.AreEqual("item has been checked in", library.checkInProduct("JUnit Rocks"));
    }

    [Test]
    public void shouldDeclineCheckInIfNotOnLoan()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Library library = new Library();
        Book book = new Book("JUnit Rocks", author);
        library.addToStock(book);

        Assert.AreEqual("item is not currently on loan", library.checkInProduct("JUnit Rocks"));
    }
}