using Atech.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Atech.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
                
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public virtual DbSet<Tbl_User> tbl_Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tbl_User>(entity =>
            {

                entity.ToTable("Tbl_User");
                entity.Property(e=>e.UserId).ValueGeneratedOnAdd();
                entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasMaxLength(50)
                .IsUnicode(false);
                entity.Property(e => e.Name)
               .HasMaxLength(50)
               .HasMaxLength(50)
               .IsUnicode(false);
                entity.Property(e => e.Email)
               .HasMaxLength(50)
               .HasMaxLength(50)
               .IsUnicode(false);
                entity.Property(e => e.Password)
               .HasMaxLength(50)
               .HasMaxLength(50)
               .IsUnicode(false);
                entity.Property(e => e.Phone)
               .HasMaxLength(50)
               .HasMaxLength(50)
               .IsUnicode(false);
                entity.Property(e => e.Gender)
               .HasMaxLength(50)
               .HasMaxLength(50)
               .IsUnicode(false);
               
                entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
               
            });

            base.OnModelCreating(modelBuilder);
        }
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

