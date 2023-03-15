using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebSach.Models
{
    public partial class WebBookDb : DbContext
    {
        public WebBookDb()
            : base("name=WebBookDb")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Chapter> Chapter { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Reaction> Reaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Status)
                .IsFixedLength();
        }
    }
}
