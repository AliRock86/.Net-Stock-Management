using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stock_Management.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SearchName { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string VendorName { get; set; }

        [Required]
        public string VonderCode { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int SubCategoryId { get; set; }

        [NotMapped]
        public string SubCategoryName { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public int StatusId { get; set; }

        [NotMapped]
        public string StatusName { get; set; }

        public virtual Status Status { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public DateTime? CreatedDate { get; set; }


        [Required]
        public DateTime? UpdatedDate { get; set; }
    }
}
