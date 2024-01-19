using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test;

public class ProductTests
{
    [Test]
    public void shouldCheckOutIfAvailable()
    {
        Product item = new Product("JUnit Rocks");
        Assert.AreEqual("item has been checked out", item.checkOut());
    }

    [Test]
    public void shouldDeclineIfNotAvailableToCheckout()
    {
        Product item = new Product("JUnit Rocks");
        item.checkOut();

        Assert.AreEqual("item is currently on loan", item.checkOut());
    }

    [Test]
    public void shouldCheckInIfOnLoan()
    {
        Product item = new Product("JUnit Rocks");
        item.checkOut();

        Assert.AreEqual("item has been checked in", item.checkIn());
    }

    [Test]
    public void shouldDeclineCheckInIfNotOnLoan()
    {
        Product item = new Product("JUnit Rocks");

        Assert.AreEqual("item is not currently on loan", item.checkIn());
    }
}