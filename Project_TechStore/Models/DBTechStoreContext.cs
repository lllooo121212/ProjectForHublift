using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Project_TechStore.Models
{
    public partial class DBTechStoreContext : DbContext
    {
        public DBTechStoreContext()
            : base("name=DBTechStoreContext")
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartDetail> CartDetails { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<Cart>().Property(e => e.CartId)
                .HasColumnName("CartID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<Cart>().Property(e => e.CustomerId).HasColumnName("CustomerID");
            modelBuilder.Entity<Cart>().Property(e => e.TotalPayment).HasPrecision(10, 2);
            modelBuilder.Entity<Cart>().HasRequired(d => d.Customer)
                .WithMany(p => p.Carts)
                .HasForeignKey(d => d.CustomerId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<CartDetail>().ToTable("CartDetail");
            modelBuilder.Entity<CartDetail>().Property(e => e.CartDetailId)
                .HasColumnName("CartDetailID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<CartDetail>().Property(e => e.CartId).HasColumnName("CartID");
            modelBuilder.Entity<CartDetail>().Property(e => e.ProductId).HasColumnName("ProductID");
            modelBuilder.Entity<CartDetail>().Property(e => e.ProductType).HasMaxLength(50).IsUnicode(false);
            modelBuilder.Entity<CartDetail>().Property(e => e.Status).HasMaxLength(20).IsUnicode(false);
            modelBuilder.Entity<CartDetail>().Property(e => e.TotalAmount).HasPrecision(10, 2);
            modelBuilder.Entity<CartDetail>().Property(e => e.UnitPrice).HasPrecision(10, 2);
            modelBuilder.Entity<CartDetail>().HasRequired(d => d.Cart)
                .WithMany(p => p.CartDetails)
                .HasForeignKey(d => d.CartId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<CartDetail>().HasRequired(d => d.Product)
                .WithMany(p => p.CartDetails)
                .HasForeignKey(d => d.ProductId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().Property(e => e.CategoryId)
                .HasColumnName("CategoryID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<Category>().Property(e => e.CategoryName).HasMaxLength(50).IsUnicode(false);

            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().Property(e => e.CustomerId).HasColumnName("CustomerID");
            modelBuilder.Entity<Customer>().Property(e => e.Address).HasColumnType("text");
            modelBuilder.Entity<Customer>().Property(e => e.Email).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(e => e.FullName).HasMaxLength(100).IsUnicode(false);
            modelBuilder.Entity<Customer>().Property(e => e.PasswordHash).HasMaxLength(255).IsUnicode(false);
            modelBuilder.Entity<Customer>().Property(e => e.PhoneNumber).HasMaxLength(15);
            modelBuilder.Entity<Customer>().Property(e => e.Username).HasMaxLength(50);

            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail");
            modelBuilder.Entity<OrderDetail>().Property(e => e.OrderDetailId)
                .HasColumnName("OrderDetailID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<OrderDetail>().Property(e => e.OrderId).HasColumnName("OrderID");
            modelBuilder.Entity<OrderDetail>().Property(e => e.ProductId).HasColumnName("ProductID");
            modelBuilder.Entity<OrderDetail>().Property(e => e.ProductType).HasMaxLength(50).IsUnicode(false);
            modelBuilder.Entity<OrderDetail>().Property(e => e.TotalAmount).HasPrecision(10, 2);
            modelBuilder.Entity<OrderDetail>().Property(e => e.UnitPrice).HasPrecision(10, 2);
            modelBuilder.Entity<OrderDetail>().Property(e => e.VoucherId).HasColumnName("VoucherID");
            modelBuilder.Entity<OrderDetail>().HasRequired(d => d.Order)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<OrderDetail>().HasRequired(d => d.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<OrderDetail>().HasOptional(d => d.Voucher)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.VoucherId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
            modelBuilder.Entity<OrderItem>().HasKey(e => e.OrderId);
            modelBuilder.Entity<OrderItem>().Property(e => e.OrderId)
                .HasColumnName("OrderID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<OrderItem>().Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Entity<OrderItem>().Property(e => e.CustomerId).HasColumnName("CustomerID");
            modelBuilder.Entity<OrderItem>().Property(e => e.GrandTotal).HasPrecision(10, 2);
            modelBuilder.Entity<OrderItem>().Property(e => e.MessageForSeller).HasColumnType("text");
            modelBuilder.Entity<OrderItem>().Property(e => e.ShippingAddress).HasColumnType("text");
            modelBuilder.Entity<OrderItem>().Property(e => e.ShippingFee).HasPrecision(10, 2);
            modelBuilder.Entity<OrderItem>().Property(e => e.TotalAmount).HasPrecision(10, 2);
            modelBuilder.Entity<OrderItem>().Property(e => e.VoucherId).HasColumnName("VoucherID");
            modelBuilder.Entity<OrderItem>().HasRequired(d => d.Customer)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.CustomerId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<OrderItem>().HasOptional(d => d.Voucher)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.VoucherId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>().Property(e => e.ProductId)
                .HasColumnName("ProductID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<Product>().Property(e => e.CategoryId).HasColumnName("CategoryID");
            modelBuilder.Entity<Product>().Property(e => e.CommentListId).HasColumnName("CommentListID");
            modelBuilder.Entity<Product>().Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Entity<Product>().Property(e => e.Description).HasColumnType("text");
            modelBuilder.Entity<Product>().Property(e => e.ImageList).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(e => e.Price).HasPrecision(10, 2);
            modelBuilder.Entity<Product>().Property(e => e.ProductName).HasMaxLength(100).IsUnicode(false);
            modelBuilder.Entity<Product>().Property(e => e.Rating).HasPrecision(3, 2);
            modelBuilder.Entity<Product>().Property(e => e.Version).HasMaxLength(50).IsUnicode(false);
            modelBuilder.Entity<Product>().Property(e => e.VoucherListId).HasColumnName("VoucherListID");
            modelBuilder.Entity<Product>().HasRequired(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Voucher>().ToTable("Voucher");
            modelBuilder.Entity<Voucher>().Property(e => e.VoucherId)
                .HasColumnName("VoucherID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<Voucher>().Property(e => e.DiscountAmount).HasPrecision(5, 2);
            modelBuilder.Entity<Voucher>().Property(e => e.ExpiryDate).HasColumnType("date");
            modelBuilder.Entity<Voucher>().Property(e => e.MaxDiscountValue).HasPrecision(10, 2);
        }
    }
}