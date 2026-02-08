using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using VendeurGroupy.Models;
namespace VendeurGroupy.Data
{
    class GroupyContext : DbContext
    {
        DbSet<Categories> Categories { get; set; }
        DbSet<NoteInternes> NoteInternes { get; set; }
        DbSet<Preventes> Preventes { get; set; }
        DbSet<Signalements> Signalements { get; set; }
        DbSet<Clients> Clients { get; set; }
        DbSet<Produits> Produits { get; set; }
        DbSet<Vendeurs> Vendeurs { get; set; }
        DbSet<MouvementStocks> MouvementStocks { get; set; }
        DbSet<Expeditions> Expeditions { get; set; }
        DbSet<Categories> Categorie { get; set; }
        DbSet<Stocks> Stocks { get; set; }
        public DbSet<Utilisateurs> Utilisateurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                string server = "localhost";
                string database = "vente_groupy";
                string user = "tse";
                string password = "Street1-Grading3-Hydration9";

                string connectionString = $"Server={server};Database={database};User={user};Password={password};";

                optionsBuilder
                    .UseMySql(
                        connectionString,
                        new MySqlServerVersion(new Version(8, 0, 39))
                    )
                    .EnableSensitiveDataLogging() // affiche les valeurs des paramètres
                    .EnableDetailedErrors()       // erreurs EF plus explicites
                    .LogTo(
                        Console.WriteLine,
                        LogLevel.Information
                    );

                // Activer les logs SQL pour le debug (optionnel)
                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ================================================
            // PRODUIT
            // ================================================

            modelBuilder.Entity<Produits>()
                .HasOne(p => p.Vendeurs)
                .WithMany()
                .HasForeignKey(p => p.id_vendeur)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Produits>()
                .HasOne(p => p.Categories)
                .WithMany()
                .HasForeignKey(p => p.Id_categorie)
                .OnDelete(DeleteBehavior.Restrict);

            // ================================================
            // PREVENTE
            // ================================================

            modelBuilder.Entity<Preventes>()
                .HasOne(p => p.Produits)
                .WithMany()
                .HasForeignKey(p => p.id_produit)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Preventes>()
                .HasOne(p => p.Clients)
                .WithMany()
                .HasForeignKey(p => p.id_client)
                .OnDelete(DeleteBehavior.Restrict);

            // Contrainte unique : un client ne peut pas commander 2 fois le même produit
            modelBuilder.Entity<Preventes>()
                .HasIndex(p => new { p.id_produit, p.id_client })
                .IsUnique();

            // ================================================
            // STOCK
            // ================================================

            modelBuilder.Entity<Stocks>()
                .HasOne(s => s.Produits)
                .WithMany()
                .HasForeignKey(s => s.Id_produit)
                .OnDelete(DeleteBehavior.Cascade);

            // Un produit = un stock unique
            modelBuilder.Entity<Stocks>()
                .HasIndex(s => s.Id_produit)
                .IsUnique();

            // ================================================
            // MOUVEMENT STOCK
            // ================================================

            modelBuilder.Entity<MouvementStocks>()
                .HasOne(m => m.Produits)
                .WithMany()
                .HasForeignKey(m => m.id_produit)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MouvementStocks>()
                .HasOne(m => m.Vendeurs)
                .WithMany()
                .HasForeignKey(m => m.id_vendeur)
                .OnDelete(DeleteBehavior.Restrict);

            // ================================================
            // EXPEDITION
            // ================================================

            modelBuilder.Entity<Expeditions>()
                .HasOne(e => e.Preventes)
                .WithMany()
                .HasForeignKey(e => e.Id_prevente)
                .OnDelete(DeleteBehavior.Restrict);

            // Une prévente = une expédition unique
            modelBuilder.Entity<Expeditions>()
                .HasIndex(e => e.Id_prevente)
                .IsUnique();

            // Numéro de tracking unique
            modelBuilder.Entity<Expeditions>()
                .HasIndex(e => e.Numero_tracking)
                .IsUnique();

            // ================================================
            // NOTE INTERNE
            // ================================================

            modelBuilder.Entity<NoteInternes>()
                .HasOne(n => n.Preventes)
                .WithMany()
                .HasForeignKey(n => n.Id_prevente)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<NoteInternes>()
                .HasOne(n => n.Vendeurs)
                .WithMany()
                .HasForeignKey(n => n.Id_vendeur)
                .OnDelete(DeleteBehavior.Restrict);

            // ================================================
            // FACTURE
            // ================================================

            modelBuilder.Entity<Facture>()
                .HasOne(f => f.Preventes)
                .WithMany()
                .HasForeignKey(f => f.Id_prevente)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Facture>()
                .HasOne(f => f.Vendeurs)
                .WithMany()
                .HasForeignKey(f => f.Id_vendeur)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Facture>()
                .HasOne(f => f.Clients)
                .WithMany()
                .HasForeignKey(f => f.Id_user)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Facture>()
                .HasOne(f => f.Produits)
                .WithMany()
                .HasForeignKey(f => f.Id_produit)
                .OnDelete(DeleteBehavior.Restrict);

            // Une prévente = une facture unique
            modelBuilder.Entity<Facture>()
                .HasIndex(f => f.Id_prevente)
                .IsUnique();

            // Numéro de facture unique
            modelBuilder.Entity<Facture>()
                .HasIndex(f => f.Id_facture)
                .IsUnique();

            // ================================================
            // SIGNALEMENT
            // ================================================

            modelBuilder.Entity<Signalements>()
                .HasOne(s => s.Produits)
                .WithMany()
                .HasForeignKey(s => s.Id_produit)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Signalements>()
                .HasOne(s => s.Clients)
                .WithMany()
                .HasForeignKey(s => s.Id_user)
                .OnDelete(DeleteBehavior.Cascade);

            // Un client ne peut signaler qu'une fois le même produit
            modelBuilder.Entity<Signalements>()
                .HasIndex(s => new { s.Id_produit, s.Id_user })
                .IsUnique();

            // ================================================
            // CONFIGURATION DES TYPES DECIMAUX
            // ================================================

            // Produits - Prix
            modelBuilder.Entity<Produits>()
                .Property(p => p.prix_initial)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Produits>()
                .Property(p => p.prix_groupe)
                .HasPrecision(10, 2);

            // Stocks - Prix d'achat
            modelBuilder.Entity<Stocks>()
                .Property(s => s.prix_achat)
                .HasPrecision(10, 2);

            // Expéditions - Poids
            modelBuilder.Entity<Expeditions>()
                .Property(e => e.poids)
                .HasPrecision(8, 2);

            // Factures - Montants
            modelBuilder.Entity<Facture>()
                .Property(f => f.prix_initial)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Facture>()
                .Property(f => f.montantTTC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Facture>()
                .Property(f => f.TVA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Facture>()
                .Property(f => f.montantTTC)
                .HasPrecision(10, 2);
        }

    }
}
