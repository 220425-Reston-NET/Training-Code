namespace PokeModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            Id = 0;
            Name = "Default";
            Quantity = 0;
        }
    }
}