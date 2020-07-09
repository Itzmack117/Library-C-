namespace Library.Models
{
    public class Film
    {
      public Film(string title, string director, int instock)
      {
        Title = title;
        Director = director;
        InStock = instock;
      }
          public string Title { get; set; }
          public string Director { get; set; }
          public int InStock { get; set; }

          public override string ToString()
    {
      return $"{Title}, directed by {Director}, {InStock} copies avaliable";
    }
    }
}