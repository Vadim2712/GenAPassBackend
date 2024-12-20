using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenAPassBackend.Models
{
    [Table("userService")]
    public class UserService
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }

        [ForeignKey("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Column("passord_hash", TypeName = "int(11)")]
        [Required]
        public int passordHash { get; set; }

        [Column("last_update")]
        [Required]
        public string LastUpdate { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("service_id")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
