namespace PokeModel
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Store()
        {
            Id = 0;
            Name = "Default";
            Products = new List<Product>();
        }
        
    }
}