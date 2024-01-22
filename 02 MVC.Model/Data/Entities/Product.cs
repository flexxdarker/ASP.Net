namespace _02_MVC.Model.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public bool InStock { get; set; }
        public string ImageUrl { get; set; }
        public int Discount { get; set; }
        public int Rating { get; set; }
    }
}
