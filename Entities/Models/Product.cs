using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reposatywithuow.Entities.Models
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 15, ErrorMessage = "Title Must Be Between 15 - 200 Char")]
        public string Title { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }

        [Range(1, 1000000, ErrorMessage = "Price Must Be Bigger Than 1")]
        public decimal Price { get; set; }

        public decimal? DiscountPercentage { get; set; }

        public decimal? Rating { get; set; }

        [Required]
        public int Stock { get; set; }

        public string? Brand { get; set; }

        public byte? Thumbnail { get; set; }

        public virtual Category Category { get; set; }


    }
}
