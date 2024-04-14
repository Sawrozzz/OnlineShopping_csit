using System.ComponentModel.DataAnnotations;

namespace OnlineShopping_csit.Models
{
    public class User

    {    
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="Email is requird")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email is invalid")]
        [StringLength(maximumLength:50, ErrorMessage ="Max characters is 50")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "At least 8 characters")]
        public string Password { get; set; }

        public string? UserType  { get; set; }
    }
}
