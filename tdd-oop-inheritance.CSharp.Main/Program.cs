// See https://aka.ms/new-console-template for more information
using tdd_oop_inheritance.CSharp.Main;

Console.WriteLine("Hello, World!");

Library library = new Library();
Article article = new Article("test");
Book book = new Book("lala");
Book book2 = new Book("test");
library.addToStock(book);
library.addToStock(book2);

Console.WriteLine(book.checkInBook("lala"));
foreach(var item in library.Books)
{
    Console.WriteLine(item.title);
}
