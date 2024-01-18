namespace tdd_oop_inheritance.CSharp.Main
{

    public class Library
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>();

        public void AddToStock(LibraryItem item)
        {
            libraryItems.Add(item);
        }

        public string CheckIn(string title)
        {
            var item = libraryItems.FirstOrDefault(i => i.Title == title);
            return item?.CheckIn() ?? "item is not part of the library's collection";
        }

        public string CheckOut(string title)
        {
            var item = libraryItems.FirstOrDefault(i => i.Title == title);
            return item?.CheckOut() ?? "item is not part of the library's collection";
        }
    }
}