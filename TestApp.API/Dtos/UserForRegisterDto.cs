using System.ComponentModel.DataAnnotations;

namespace TestApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage = "You muste specify password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}