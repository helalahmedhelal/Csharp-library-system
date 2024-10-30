using System.Collections.Generic;

public class Library{
    private List<Book> books= new List<Book>();

    public void AddBook(Book book){
        books.Add(book);
        Console.WriteLine($"successfully added {book.Title} as a new book");
    }

    public void RemoveBook(string isbn){
        Book bookToRemove = books.Find(book => book.ISBN == isbn);  
        if(bookToRemove != null){
                books.Remove(bookToRemove);
                Console.WriteLine($"successfully remove book with this {isbn}!");
            }
            else{
                Console.WriteLine($"can't find book with this {isbn}");
            }
    }
    
    public void CheckOutBook(string isbn){
        Book bookToCheckOut  = books.Find(book => book.ISBN == isbn); 
            if(bookToCheckOut != null){
                bookToCheckOut.CheckOut();
                Console.WriteLine($"the book {bookToCheckOut.Title} with this {isbn} is checked out from library");
                
            }
            else{
                Console.WriteLine($"can't find book with this {isbn}");
            }
        
    }
    public void ReturnBook(string isbn){
       Book bookToReturn  = books.Find(book => book.ISBN == isbn); 
        if(bookToReturn != null){
            bookToReturn.Return();
            Console.WriteLine($"the book {bookToReturn.Title} with this {isbn} returned to library");
        }
        else{
                Console.WriteLine($"can't find book with this {isbn}");
            }
       }
    
    public void DisplayBooks(){
        if(books.Count == 0){
            Console.WriteLine("No books to Display");
        }
        else{
        Console.WriteLine("Library list of books");
        foreach(Book book in books){
            Console.WriteLine(book.ToString());
        }
    }
    }
}