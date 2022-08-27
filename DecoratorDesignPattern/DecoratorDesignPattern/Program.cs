using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();
            LibraryItem bookItem = new Book("ahas", "hags", 2);
           
            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");
            Borowable borrowvideo = new Borowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.Display();

            // Make book borrowable, then borrow and display
            Console.WriteLine("\nMaking book borrowable:");
            Borowable borrowbook = new Borowable(book);
            borrowvideo.BorrowItem("Customer #3");
            borrowvideo.BorrowItem("Customer #4");
            borrowvideo.Display();
            Console.ReadLine();
        }
    }
}
