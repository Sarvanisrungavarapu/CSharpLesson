using System.ComponentModel.DataAnnotations;

namespace LibraryA
{
    public class Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;
        public string Gener = string.Empty;
        public DataType DateOfPublish;
        public int BookPrice;
        public int TotalPages=300;
        
        public Book()
        {
            Console.WriteLine("Book Obj Created");
        }
        public void OpenBook()
        {
            Console.WriteLine("Book is open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No:{pageNo} Bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }
    }
}