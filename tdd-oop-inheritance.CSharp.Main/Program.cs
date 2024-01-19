// See https://aka.ms/new-console-template for more information
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

Console.WriteLine("Hello, World!");


Library lib = new Library();




Book book1 = new Book("A Song of Ice and Fire");
Library library = new Library();
library.addToStock(book1);
library.checkIn("A Song of Ice and Fire");
Assert.That(library.checkIn("Fellowship Of The Ring").Equals("item is not part of the library's collection"));
Assert.That(library.checkIn("Fellowship Of The Ring").Equals(""));

