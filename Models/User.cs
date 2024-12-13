using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenAPassBackend.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }

        [Column("email", TypeName = "text")]
        [Required]
        public string Email { get; set; }

        [Column("icon_url", TypeName = "text")]
        public string  IconUrl { get; set; }

        [Column("hash", TypeName = "int(11)")]
        [Required]
        public int Hash { get; set; }

        [Column("create_at", TypeName = "text")]
        [Required]
        public DateTime CreatedAt { get; set; }
        
        [Column("active", TypeName = "TINYINT(1)")]
        [Required] 
        public bool IsActive { get; set; }

        public ICollection<UserService> UserServices { get; set; } = new List<UserService>();

    }
}
