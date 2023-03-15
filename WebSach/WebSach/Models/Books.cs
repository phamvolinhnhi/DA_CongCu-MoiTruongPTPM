namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Book_Id { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }

        [StringLength(250)]
        public string Category { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime? Create_at { get; set; }

        public DateTime? Update_at { get; set; }
    }
}
