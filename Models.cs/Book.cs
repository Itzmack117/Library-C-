namespace Library.Models
{
  public class Book
  {
public Book(string title, string author, int InStock, bool Available)
{
    Title = title;
    Author = author;
    Available = true;
}
    public string Title { get; set; }
    public string Author { get; set; }
    public int InStock { get; set; }
    public bool Available { get { return InStock > 0; } }

    public override string ToString()
    {
      return $"{Title} by {Author}, {InStock} copies avaliable ";
    }

  }
}