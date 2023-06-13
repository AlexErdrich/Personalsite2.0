using System.ComponentModel.DataAnnotations;
using PersonalSite.Controllers;

namespace PersonalSite.Models
{
    public class ContactViewModel
    {
        //We can use DataAnnotations to add validation to our model.
        //This is Useful when we have required fields or need certain types of  info. 
        [Required(ErrorMessage = "* Required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.EmailAddress)] //enforces standard email formatting
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        public string Subject { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.MultilineText)]// Gives us a larger text (textarea)
        public string Message { get; set; } = null!;

    }
}