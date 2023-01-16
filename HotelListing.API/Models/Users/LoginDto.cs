using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Users;

public class LoginDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(15, ErrorMessage = "Your Password must be between {2} and {1} characters in length", MinimumLength = 6)]
    public string Password { get; set; }
}
