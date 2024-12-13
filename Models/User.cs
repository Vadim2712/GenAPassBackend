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
        public string Email { get; set; }

        [Column("hash", TypeName = "int(11)")]
        public int Hash { get; set; }

        [Column("create", TypeName = "text")]
        public DateTime CreatedAt { get; set; }
        
        [Column("active", TypeName = "text")]
        public bool IsActive { get; set; }
    }
}
