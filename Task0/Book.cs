using System;
using System.Reflection.Metadata.Ecma335;
public class Book{
    private string title;
    private string author;
    private string isbn;
    private bool ischeckedout;

    public Book(string title, string author, string isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        ischeckedout = false;
    }
    public string Title{
        get{
            return title;
        }

        set{
            title = value;
        }
    }
    public string Author{
        get{
            return author;
        }
        set { 
            author = value; 
        }
    }
    public string ISBN{
        get{
            return isbn;
        }
        set{ 
            isbn = value; 
        }
    }
    public bool IsCheckedOut{
        get{
            return ischeckedout;
        }
        set{
            ischeckedout = value;
        }
    }

    public void CheckOut(){
        if (!ischeckedout)
        {
            ischeckedout = true;
            Console.WriteLine($"Book '{Title}' has been checked out.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' is already checked out.");
        }
    }

    public void Return(){
        if (ischeckedout)
        {
            ischeckedout = false;
            Console.WriteLine($"Book '{Title}' has been returned.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' is already exists in library");
        }
    }

    public override string ToString(){
       string availability;
       if (ischeckedout){
        availability="Book is not avilable in library";
       }else {
        availability="Book avilable in library";
       }
       return $"Book title is {title}, book Author is {author}, book ISBN {isbn}, book status is {availability}";
    }
    
    
}