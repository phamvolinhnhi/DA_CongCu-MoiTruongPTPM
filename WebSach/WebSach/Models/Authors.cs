namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Authors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Author_Id { get; set; }

        [StringLength(50)]
        public string Author_Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
