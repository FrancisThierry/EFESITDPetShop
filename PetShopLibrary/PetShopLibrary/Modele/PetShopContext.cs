using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.Modele
{
    public class PetShopContext : DbContext
    {
        string DbPath = @"C:\projets\TDEF\petShop.db";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {DbPath}");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasOne<Panier>(s => s.Panier)
                .WithOne(p => p.Client)
                .HasForeignKey<Panier>(p => p.ClientId);

            modelBuilder.Entity<Panier>()
                .HasMany(p => p.Produits)
                .WithOne(p => p.Panier)
                .HasForeignKey(p => p.PanierId);
            //.IsRequired();

            modelBuilder.Entity<Promotion>()
              .HasMany(p => p.Produits)
              .WithOne(p => p.Promotion)
              .HasForeignKey(p => p.PromotionID);
            //.IsRequired();

            modelBuilder.Entity<Categorie>()
               .HasMany(p => p.Produits)
               .WithOne(p => p.Categorie)
               .HasForeignKey(p => p.CategorieID);



        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
    }
}
