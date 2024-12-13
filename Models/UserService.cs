using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenAPassBackend.Models
{
    [Table("user")]
    public class UserService
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }

        
    }
}
