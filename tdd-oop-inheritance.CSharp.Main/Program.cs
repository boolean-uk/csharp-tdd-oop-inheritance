// See https://aka.ms/new-console-template for more information
using tdd_oop_inheritance.CSharp.Main;

Console.WriteLine("Hello, World!");

Library lib = new Library();
Author auth = new Author("test", "test", "test");
Book book = new Book("bok", auth);

lib.checkInLibraryItem(book.title);