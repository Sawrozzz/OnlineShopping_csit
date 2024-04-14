using System.ComponentModel.DataAnnotations;
namespace OnlineShopping_csit.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tittle is required")]
        [StringLength(50,ErrorMessage ="Max characters is 50")]

        public string Title { get; set; }
        [StringLength(500, ErrorMessage = "Max characters is 500")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]

        public int Price { get; set; }

        public string ? Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category ? Category { get; set; }
        }
}
