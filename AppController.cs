using System;
using Library.Models;

namespace Library
{
  public class App
  {
    public Shelf Shelf{get; set;} = new Shelf();
    public bool Running { get; private set; }

    public void Run()
    {
      //  while (Running == true)
      //  {
          System.Console.WriteLine("Welcome to The Library! \nWhat Would you like to do? Check out Book / Stock / Quit");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
          case "check out book":
          case "c":
          case "check out":
          case "checkout":
            ChkOutBook();
            break;
          case "stock":
          case "s":
          case "restock":
            // StockBooks();
            break;
          case "quit":
          case "q":
          case "end":
            // Running = false;
            System.Console.WriteLine("Goodbye");
            break;
          default:
            System.Console.WriteLine("Invalid Command");
            break;
        }
       }
           public void ChkOutBook()
    {
      Console.Clear();
      Shelf.ViewBooks();
      System.Console.WriteLine("Select a book to check out");
      string selection = Console.ReadLine();
      Book selectedBook = Shelf.checkBook(selection);
      if (selectedBook == null)
      {
        System.Console.WriteLine("Invalid Selection");
        return;
      }else{
        Console.WriteLine($"Enjoy reading {selectedBook.Title}, please take good care of it!");
      }
    }
  }
}
  
// }