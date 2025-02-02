﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stock_Management.Models
{
    public class PermissionUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int PermissionTypeId { get; set; }


        [NotMapped]
        public string PermissionTypeName { get; set; }

        public virtual PermissionType PermissionType { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }


        [Required]
        public DateTime? CreatedDate { get; set; }


        [Required]
        public DateTime? UpdatedDate { get; set; }
    }
}
