using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reposatywithuow.Entities.Models
{
    [Table("order")]
    public class order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }


        [Column("name")]
        public string? Name { get; set; }
    }
}
