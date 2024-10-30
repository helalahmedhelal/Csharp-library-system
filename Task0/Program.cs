using System; 
     
public class Program 
    {  
       public static void Main(string[] args)  
        {  
           
            Library library= new Library();
            bool run=true;
            while (run)
        {
            Console.WriteLine("\nLibrary System Menu:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. View all books");
            Console.WriteLine("4. Check out a book");
            Console.WriteLine("5. Return a book");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBookToLibrary(library);
                    break;
                case "2":
                    RemoveBookFromLibrary(library);
                    break;
                case "3":
                    library.DisplayBooks();
                    break;
                case "4":
                    CheckOutBookFromLibrary(library);
                    break;
                case "5":
                    ReturnBookToLibrary(library);
                    break;
                case "6":
                    run = false;
                    Console.WriteLine("Exiting the library system.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void AddBookToLibrary(Library library)
    {
        Console.Write("Enter the title of the book: ");
        string title = Console.ReadLine();

        Console.Write("Enter the author of the book: ");
        string author = Console.ReadLine();

        Console.Write("Enter the ISBN of the book: ");
        string isbn = Console.ReadLine();

        if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn)){
            Console.WriteLine("pleas enter valid data");
        }else{
          Book book = new Book(title, author, isbn);
          library.AddBook(book);
        }
        
    }

    private static void RemoveBookFromLibrary(Library library)
    {
        Console.Write("Enter the ISBN of the book to remove: ");
        string isbn = Console.ReadLine();

        library.RemoveBook(isbn);
    }

    private static void CheckOutBookFromLibrary(Library library)
    {
        Console.Write("Enter the ISBN of the book to check out: ");
        string isbn = Console.ReadLine();

        library.CheckOutBook(isbn);
    }

    private static void ReturnBookToLibrary(Library library)
    {
        Console.Write("Enter the ISBN of the book to return: ");
        string isbn = Console.ReadLine();

        library.ReturnBook(isbn);
    }
            
              
}      