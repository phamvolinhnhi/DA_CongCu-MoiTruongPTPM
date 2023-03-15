namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [StringLength(50)]
        public string AccountAdmin { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? Create_at { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
