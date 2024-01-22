namespace _02_MVC.Model.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Poducts { get; set;}
    }
}
