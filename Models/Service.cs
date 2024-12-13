using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenAPassBackend.Models
{
    [Table("service")]
    public class Service
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }

        [Column("name", TypeName = "text")]
        public string Name {  get; set; }

        [Column("url",  TypeName = "text")]
        public string Url { get; set; }
    }
}
