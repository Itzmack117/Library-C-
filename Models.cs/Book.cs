namespace Library.Models
{
  public class Book
  {
public Book(string title, string author, int instock)
{
    Title = title;
    Author = author;
    InStock = instock;
}
    public string Title { get; set; }
    public string Author { get; set; }
    public int InStock { get; set; }

    public override string ToString()
    {
      return $"{Title} by {Author}, {InStock} copies avaliable";
    }

  }
}