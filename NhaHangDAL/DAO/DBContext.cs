using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using NhaHangDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO
{
    public class NhaHangDBContext : DbContext
    {
        public NhaHangDBContext(DbContextOptions<NhaHangDBContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Table> Tables => Set<Table>();
        public DbSet<Staff> Staffs => Set<Staff>();
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<WorkShift> WorkShifts => Set<WorkShift>();
        public DbSet<Invoice> Invoices => Set<Invoice>();
        public DbSet<InvoiceDetail> InvoiceDetails => Set<InvoiceDetail>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>()
                .HasOne(f => f.Category)
                .WithMany(c => c.Foods)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Account>()
                .HasOne(a => a.Staff)
                .WithOne(s => s.Account)
                .HasForeignKey<Account>(a => a.StaffId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WorkShift>()
                .HasOne(ws => ws.Staff)
                .WithMany(s => s.WorkShifts)
                .HasForeignKey(ws => ws.StaffId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Staff)
                .WithMany(s => s.Invoices)
                .HasForeignKey(i => i.StaffId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Table)
                .WithMany(t => t.Invoices)
                .HasForeignKey(i => i.TableId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.WorkShift)
                .WithMany(ws => ws.Invoices)
                .HasForeignKey(i => i.ShiftId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(d => d.Invoice)
                .WithMany(i => i.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(d => d.Food)
                .WithMany(f => f.InvoiceDetails)
                .HasForeignKey(d => d.FoodId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvoiceDetail>()
                .HasKey(x => new { x.InvoiceId, x.FoodId });


            modelBuilder.Entity<Food>()
                .Property(x => x.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Invoice>()
                .Property(x => x.TotalMoney)
                .HasPrecision(14, 2);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(x => x.UnitPrice)
                .HasPrecision(12, 2);


            modelBuilder.Entity<Account>()
                .HasIndex(x => x.Username)
                .IsUnique();


            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Món chính", Description = "Các món ăn chính" },
                new Category { CategoryId = 2, CategoryName = "Đồ uống", Description = "Nước giải khát" }
            );
        }
    }
}
