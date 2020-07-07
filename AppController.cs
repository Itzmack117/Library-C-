using System;
using Library.Models;

namespace Library
{
  public class App
  {
    public bool Running { get; private set; }

    public void Run()
    {
       while (Running)
       {
          System.Console.WriteLine("Welcome to The Library! \nWhat Would you like to do? Check out Book / Stock / Quit");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
          case "check out book":
          case "c":
          case "check out":
          case "checkout":
            // ChkOutBook();
            break;
          case "stock":
          case "s":
          case "restock":
            // StockBooks();
            break;
          case "quit":
          case "q":
          case "end":
            Running = false;
            System.Console.WriteLine("Goodbye");
            break;
          default:
            System.Console.WriteLine("Invalid Command");
            break;
        }
       }
    }
  }
}