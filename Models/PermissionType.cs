using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stock_Management.Models
{
    public class PermissionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string PermissionTypeName { get; set; }
        [Required]
        public string PermissionTypeNameArb { get; set; }
        public virtual ICollection<PermissionUser> PermissionUsers { get; set; }
    }
}
