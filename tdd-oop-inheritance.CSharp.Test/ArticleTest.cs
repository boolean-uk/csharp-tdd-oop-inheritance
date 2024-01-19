using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test;

class ArticleTest
{
    [Test]
    public void shouldCheckOutIfAvailable()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Article article = new Article("JUnit Rocks", author);
        Assert.AreEqual("item has been checked out", article.checkOut());
    }

    [Test]
    public void shouldDeclineIfNotAvailableToCheckout()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Article article = new Article("JUnit Rocks", author);
        article.checkOut();

        Assert.AreEqual("item is currently on loan", article.checkOut());
    }

    [Test]
    public void shouldCheckInIfOnLoan()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Article article = new Article("JUnit Rocks", author);
        article.checkOut();

        Assert.AreEqual("item has been checked in", article.checkIn());
    }

    [Test]
    public void shouldDeclineCheckInIfNotOnLoan()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Article article = new Article("JUnit Rocks", author);

        Assert.AreEqual("item is not currently on loan", article.checkIn());
    }

    [Test]
    public void canGetAuthor()
    {
        Author author = new Author("Guy", "Guy@gmail.com", "https://www.guy.com");
        Article article = new Article("JUnit Rocks", author);

        Assert.AreEqual("Guy", article.Author.Name);
        Assert.AreEqual("Guy@gmail.com", article.Author.Email);
        Assert.AreEqual("https://www.guy.com", article.Author.Website);
    }
}