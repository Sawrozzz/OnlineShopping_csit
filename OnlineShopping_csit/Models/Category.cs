namespace OnlineShopping_csit.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<Product> ? Products { get; set; }
    }
}
