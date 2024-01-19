namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book(string title, Author author) : LibraryItem(title)
    {
        public Author Author { get; } = author;
    }
}
