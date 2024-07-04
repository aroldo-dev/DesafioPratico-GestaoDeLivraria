namespace DesafioPratico_GestaoDeLivraria.Contracts
{
    public class BookUpdateDto
    {
        public string Title { get; set; } = String.Empty;
        public string Author { get; set; } = String.Empty;
        public string Genre { get; set; } = String.Empty;
        public Double Price { get; set; } = 0;
        public int Quantity { get; set; } = 0;
    }
}
