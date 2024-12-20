using Microsoft.EntityFrameworkCore.Storage.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenAPassBackend.Models
{
    [Table("settings")]
    public class Settings
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }

        [ForeignKey("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Column("theme", TypeName = "TINYINT(1)")]
        [Required]
        public bool theme { get; set; }

        [Column("notification_enable", TypeName = "TINYINT(1)")]
        [Required]
        public bool NotificationEnable { get; set; }
    }
}
