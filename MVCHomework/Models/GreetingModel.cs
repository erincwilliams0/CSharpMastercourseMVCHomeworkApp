using System.ComponentModel.DataAnnotations;

namespace MVCHomework.Models
{
    public class GreetingModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
