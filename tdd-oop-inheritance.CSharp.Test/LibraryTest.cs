using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
{
    [Test]
    public void CanAddItemsToLibrary()
    {
        Library library = new Library();
        
        library.addToStock(new Article("JUnit Rocks!"));
        library.addToStock(new Book("C# for dummies"));

        Assert.That(2, Is.EqualTo(library.LibraryList.Count));

    }

    [Test]
    public void CheckOutItems()
    {
        Library library = new Library();

        Article article1 = new Article("JUnit Rocks!");
        Book book1 = new Book("C# for dummies");

        library.addToStock(article1);
        library.addToStock(book1);

        string result = library.checkOutItem(article1);

        Assert.That("item has been checked out", Is.EqualTo(result));

    }

    [Test]
    public void CheckInItems()
    {
        Library library = new Library();

        Article article1 = new Article("JUnit Rocks!");
        Book book1 = new Book("C# for dummies");

        library.addToStock(article1);
        library.addToStock(book1);

        library.checkOutItem(article1);
        string result = library.checkInItem(article1);

        Assert.That("item has been checked in", Is.EqualTo(result));

    }

    [Test]
    public void IsOnLoan()
    {
        Library library = new Library();

        Article article1 = new Article("JUnit Rocks!");
        Book book1 = new Book("C# for dummies");

        library.addToStock(article1);
        library.addToStock(book1);

        library.checkOutItem(article1);
        string result = library.checkOutItem(article1);

        Assert.That("item is currently on loan", Is.EqualTo(result));

    }
    }
}
