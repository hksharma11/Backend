using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CategoryServices.Models
{
    public partial class EcomContext : DbContext
    {
        public EcomContext()
        {
        }

        public EcomContext(DbContextOptions<EcomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EcomCategory> EcomCategory { get; set; }
        public virtual DbSet<EcomCustomers> EcomCustomers { get; set; }
        public virtual DbSet<EcomLogin> EcomLogin { get; set; }
        public virtual DbSet<EcomOrders> EcomOrders { get; set; }
        public virtual DbSet<EcomPayment> EcomPayment { get; set; }
        public virtual DbSet<EcomProducts> EcomProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Ecom;Data Source=IN3237984W1\\MSSQLSERVER01");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EcomCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("ECom_Category");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("Category_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EcomCustomers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("ECom_Customers");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasColumnName("Customer_Address")
                    .HasMaxLength(150);

                entity.Property(e => e.CustomerEmailId)
                    .IsRequired()
                    .HasColumnName("Customer_Email_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhoneNumber)
                    .IsRequired()
                    .HasColumnName("Customer_Phone_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId).HasColumnName("Login_Id");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.EcomCustomers)
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECom_Customers_ECom_Login");
            });

            modelBuilder.Entity<EcomLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("ECom_Login");

                entity.HasIndex(e => e.LoginId)
                    .HasName("Login_Id")
                    .IsUnique();

                entity.Property(e => e.LoginId).HasColumnName("Login_Id");

                entity.Property(e => e.DateTimeStamp)
                    .HasColumnName("Date_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginRole)
                    .IsRequired()
                    .HasColumnName("Login_Role")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Token).IsRequired();
            });

            modelBuilder.Entity<EcomOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("ECom_Orders");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.OrderPrice)
                    .HasColumnName("Order_Price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderQuantity).HasColumnName("Order_Quantity");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ShipmentAddress)
                    .IsRequired()
                    .HasColumnName("Shipment_Address")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.EcomOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECom_Orders_ECom_Customers");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.EcomOrders)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECom_Orders_ECom_Products");
            });

            modelBuilder.Entity<EcomPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("ECom_Payment");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_Id");

                entity.Property(e => e.CardCvv).HasColumnName("Card_CVV");

                entity.Property(e => e.CardExpiry)
                    .HasColumnName("Card_Expiry")
                    .HasColumnType("date");

                entity.Property(e => e.CardName)
                    .HasColumnName("Card_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("Card_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.PaymentMode)
                    .IsRequired()
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.EcomPayment)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECom_Payment_ECom_Customers");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.EcomPayment)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECom_Payment_ECom_Orders");
            });

            modelBuilder.Entity<EcomProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("ECom_Products");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasColumnName("Product_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductImg).HasColumnName("Product_Img");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("Product_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("Product_Price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasColumnName("Product_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.EcomProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECom_Products_ECom_Category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
