using System.ComponentModel.DataAnnotations;

namespace GenAPassBackend.DTOs
{
    public class CreateUserDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string IconUrl { get; set; }

        [Required]
        public int Hash { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
