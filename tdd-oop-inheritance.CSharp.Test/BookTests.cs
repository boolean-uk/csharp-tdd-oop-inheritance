using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test;

public class BookTests
{
    [Test]
    public void shouldCheckOutIfAvailable()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Book book = new Book("JUnit Rocks", author);
        Assert.AreEqual("item has been checked out", book.checkOut());
    }

    [Test]
    public void shouldDeclineIfNotAvailableToCheckout()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Book book = new Book("JUnit Rocks", author);
        book.checkOut();

        Assert.AreEqual("item is currently on loan", book.checkOut());
    }

    [Test]
    public void shouldCheckInIfOnLoan()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Book book = new Book("JUnit Rocks", author);
        book.checkOut();

        Assert.AreEqual("item has been checked in", book.checkIn());
    }

    [Test]
    public void shouldDeclineCheckInIfNotOnLoan()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Book book = new Book("JUnit Rocks", author);

        Assert.AreEqual("item is not currently on loan", book.checkIn());
    }

    [Test]
    public void canGetAuthor()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Book book = new Book("JUnit Rocks", author);

        Assert.AreEqual("Guy", book.Author.Name);
        Assert.AreEqual("Guy@gmail.com", book.Author.Email);
        Assert.AreEqual("https://www.guy.com", book.Author.Website);
    }
}