using System.ComponentModel.DataAnnotations;
using PersonalSite.Controllers;


namespace PersonalSite.Models
{
    public class ContactViewModel
    {
        
        [Required(ErrorMessage = "* Required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        public string Subject { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; } = null!;

    }
}