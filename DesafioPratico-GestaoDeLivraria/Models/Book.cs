namespace DesafioPratico_GestaoDeLivraria.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Author { get; set; } = String.Empty;
        public string Genre { get; set; } = String.Empty;
        public Double Price { get; set; }
        public int Quantity { get; set; }
    }
}
