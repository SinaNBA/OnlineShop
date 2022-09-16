using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using OnlineShop.Models.DomainModels;

namespace OnlineShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<FileType> FileTypes { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductFile> ProductFiles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<File>(x =>
            {
                x.HasOne(x => x.FileType)
                .WithMany(x => x.Files)
                .HasForeignKey(x => x.TypeId).IsRequired();
                x.HasKey(x => x.Id);
                x.Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");
                x.Property(p => p.Name).HasMaxLength(50).IsRequired();
                x.Property(x => x.Format).HasColumnType
                ("varchar").HasMaxLength(5).IsRequired();
                x.Property(x => x.PhysicalPath).HasColumnType
                ("varchar").HasMaxLength(200).IsRequired();
                x.Property(p => p.Size).HasMaxLength(50).IsRequired();
                x.Property(p => p.IsDownloadable).HasMaxLength(50).IsRequired();
                x.Property(p => p.CreateAt).HasDefaultValueSql("GETDATE()").IsRequired();
                x.HasMany(x => x.ProductFiles)
                .WithOne(x => x.File);
                x.HasMany(x => x.ProductCategories)
                .WithOne(x => x.File);
            });
            builder.Entity<FileType>(x =>
            {
                x.HasKey(x => x.Id);
                x.Property(p => p.Id).UseIdentityColumn();
                x.Property(p => p.Title).HasMaxLength(50).IsRequired();
                x.HasMany(p => p.Files)
                .WithOne(p => p.FileType);
                x.HasIndex(p => p.Title);
            });
            builder.Entity<Brand>(x =>
            {
                x.HasKey(x => x.Id);
                x.Property(x => x.Id).UseIdentityColumn();
                x.Property(p => p.Title).HasMaxLength(50).IsRequired();
                x.Property(p => p.Description).HasMaxLength(200);
                x.HasMany(x => x.Products)
                .WithOne(x => x.Brand);

            });
            builder.Entity<Product>(x =>
            {
                x.HasKey(x => x.Id);
                x.Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");
                x.HasOne(x => x.Brand)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.BrandId).IsRequired();
                x.HasOne(x => x.ProductCategory)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId).IsRequired();
                x.Property(p => p.Name).HasMaxLength(50).IsRequired();
                x.Property(p => p.Price).HasPrecision(10, 2).IsRequired();
                x.HasMany(x => x.ProductFiles)
                 .WithOne(x => x.Product);
            });
            builder.Entity<ProductCategory>(x =>
            {
                x.HasKey(x => x.Id);
                x.Property(x => x.Id).UseIdentityColumn();
                x.Property(p => p.Title).HasMaxLength(50).IsRequired();
                x.Property(p => p.Description).HasMaxLength(50);
                x.HasOne(x => x.File)
                .WithMany(x => x.ProductCategories)
                .HasForeignKey(x => x.FileId).IsRequired();
                x.Property(p => p.ParentId).IsRequired();
                x.HasMany(x => x.Products)
                .WithOne(x => x.ProductCategory);
            });
            builder.Entity<ProductFile>(x =>
            {
                x.HasOne(x => x.Product)
                .WithMany(x => x.ProductFiles)
                .HasForeignKey(x => x.ProductId).IsRequired();
                x.HasOne(x => x.File)
                .WithMany(x => x.ProductFiles)
                .HasForeignKey(x => x.FileId).IsRequired();
                x.HasKey(x => x.Id);
                x.Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");
                x.Property(p => p.IsDefault).IsRequired();
            });
        }
        public DbSet<OnlineShop.Models.DomainModels.BrandModel> BrandModel { get; set; }
        public DbSet<OnlineShop.Models.DomainModels.FileModel> FileModel { get; set; }
        public DbSet<OnlineShop.Models.DomainModels.FileTypeModel> FileTypeModel { get; set; }
        public DbSet<OnlineShop.Models.DomainModels.ProductModel> ProductModel { get; set; }
        public DbSet<OnlineShop.Models.DomainModels.ProductFileModel> ProductFileModel { get; set; }
    }
}
