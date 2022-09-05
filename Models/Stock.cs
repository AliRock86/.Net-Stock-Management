using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stock_Management.Models
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StockName { get; set; }
        public string StockNameArb { get; set; }
        public virtual ICollection<StockUser> StockUsers { get; set; }
    }
}
