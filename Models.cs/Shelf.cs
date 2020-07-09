using System;
using System.Collections.Generic;

namespace Library.Models
{
  public class Shelf
  {
    public List<Book> Books { get; set; } = new List<Book>();
        public void ViewBooks()
    {
      Console.WriteLine("Books Currently In Stock : \n");
      for (int i = 0; i < Books.Count; i++)
      {
        Book book = Books[i];
          System.Console.WriteLine($"{i + 1}. {book}");
      }
    }
 public Shelf()
    {
      Books.Add(new Book("Heart Of Darkness", "Jonathan Konrad", 5));
      Books.Add(new Book("1984", "George Orwell", 2));
      // add 
    }        internal Book checkBook(string selection)
    {
      int bookIndex;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > Books.Count)
      {
        return null;
      }
      return Books[bookIndex - 1];
    }
  }
}