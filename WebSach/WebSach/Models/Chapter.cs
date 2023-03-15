namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chapter")]
    public partial class Chapter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Chapter_Id { get; set; }

        public int? Chapter_Number { get; set; }

        [StringLength(250)]
        public string Chapter_Name { get; set; }

        public string Content { get; set; }
    }
}
