using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8 , MinimumLength = 4 , ErrorMessage="You Must Specify Password Between 4 and 8 chr")]
        public string Password { get; set; }
    }
}