using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net.Sockets;
using System.Security;

namespace Stock_Management.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        public int Phone { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Salt { get; set; }
        public bool Active { get; set; } = true;

        //[Required]
        public DateTime? CreatedDate { get; set; }

        //[Required]
        public DateTime? UpdatedDate { get; set; }

        [Required]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int? EmployeeId { get; set; }

        public virtual ICollection<RoleUser> FeedbackTickets { get; set; }
        public virtual ICollection<PermissionUser> PermissionUsers { get; set; }


    }
}
