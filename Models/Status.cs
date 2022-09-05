using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Management.Models
{
    public class Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string StatusNameArb { get; set; }

        public int StatusTypeId { get; set; }

        [NotMapped]
        public string StatusTypeName { get; set; }

        public virtual StatusType StatusType { get; set; }
    }
}
