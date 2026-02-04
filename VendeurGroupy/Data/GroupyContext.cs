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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // ================================================
        //    // PRODUIT
        //    // ================================================

        //    modelBuilder.Entity<Produit>()
        //        .HasOne(p => p.Vendeur)
        //        .WithMany()
        //        .HasForeignKey(p => p.IdVendeur)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Produit>()
        //        .HasOne(p => p.Categorie)
        //        .WithMany()
        //        .HasForeignKey(p => p.IdCategorie)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    // ================================================
        //    // PREVENTE
        //    // ================================================

        //    modelBuilder.Entity<Prevente>()
        //        .HasOne(p => p.Produit)
        //        .WithMany()
        //        .HasForeignKey(p => p.IdProduit)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Prevente>()
        //        .HasOne(p => p.Client)
        //        .WithMany()
        //        .HasForeignKey(p => p.IdClient)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    // Contrainte unique : un client ne peut pas commander 2 fois le même produit
        //    modelBuilder.Entity<Prevente>()
        //        .HasIndex(p => new { p.IdProduit, p.IdClient })
        //        .IsUnique();

        //    // ================================================
        //    // STOCK
        //    // ================================================

        //    modelBuilder.Entity<Stock>()
        //        .HasOne(s => s.Produit)
        //        .WithMany()
        //        .HasForeignKey(s => s.IdProduit)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // Un produit = un stock unique
        //    modelBuilder.Entity<Stock>()
        //        .HasIndex(s => s.IdProduit)
        //        .IsUnique();

        //    // ================================================
        //    // MOUVEMENT STOCK
        //    // ================================================

        //    modelBuilder.Entity<MouvementStock>()
        //        .HasOne(m => m.Produit)
        //        .WithMany()
        //        .HasForeignKey(m => m.IdProduit)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<MouvementStock>()
        //        .HasOne(m => m.Vendeur)
        //        .WithMany()
        //        .HasForeignKey(m => m.IdVendeur)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    // ================================================
        //    // EXPEDITION
        //    // ================================================

        //    modelBuilder.Entity<Expedition>()
        //        .HasOne(e => e.Prevente)
        //        .WithMany()
        //        .HasForeignKey(e => e.IdPrevente)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    // Une prévente = une expédition unique
        //    modelBuilder.Entity<Expedition>()
        //        .HasIndex(e => e.IdPrevente)
        //        .IsUnique();

        //    // Numéro de tracking unique
        //    modelBuilder.Entity<Expedition>()
        //        .HasIndex(e => e.NumeroTracking)
        //        .IsUnique();

        //    // ================================================
        //    // NOTE INTERNE
        //    // ================================================

        //    modelBuilder.Entity<NoteInterne>()
        //        .HasOne(n => n.Prevente)
        //        .WithMany()
        //        .HasForeignKey(n => n.IdPrevente)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<NoteInterne>()
        //        .HasOne(n => n.Vendeur)
        //        .WithMany()
        //        .HasForeignKey(n => n.IdVendeur)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    // ================================================
        //    // FACTURE
        //    // ================================================

        //    modelBuilder.Entity<Facture>()
        //        .HasOne(f => f.Prevente)
        //        .WithMany()
        //        .HasForeignKey(f => f.IdPrevente)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Facture>()
        //        .HasOne(f => f.Vendeur)
        //        .WithMany()
        //        .HasForeignKey(f => f.IdVendeur)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Facture>()
        //        .HasOne(f => f.Client)
        //        .WithMany()
        //        .HasForeignKey(f => f.IdClient)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Facture>()
        //        .HasOne(f => f.Produit)
        //        .WithMany()
        //        .HasForeignKey(f => f.IdProduit)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    // Une prévente = une facture unique
        //    modelBuilder.Entity<Facture>()
        //        .HasIndex(f => f.IdPrevente)
        //        .IsUnique();

        //    // Numéro de facture unique
        //    modelBuilder.Entity<Facture>()
        //        .HasIndex(f => f.NumeroFacture)
        //        .IsUnique();

        //    // ================================================
        //    // SIGNALEMENT
        //    // ================================================

        //    modelBuilder.Entity<Signalement>()
        //        .HasOne(s => s.Produit)
        //        .WithMany()
        //        .HasForeignKey(s => s.IdProduit)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<Signalement>()
        //        .HasOne(s => s.Client)
        //        .WithMany()
        //        .HasForeignKey(s => s.IdClient)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // Un client ne peut signaler qu'une fois le même produit
        //    modelBuilder.Entity<Signalement>()
        //        .HasIndex(s => new { s.IdProduit, s.IdClient })
        //        .IsUnique();

        //    // ================================================
        //    // CONFIGURATION DES TYPES DECIMAUX
        //    // ================================================

        //    // Produits - Prix
        //    modelBuilder.Entity<Produit>()
        //        .Property(p => p.PrixInitial)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<Produit>()
        //        .Property(p => p.PrixGroupe)
        //        .HasPrecision(10, 2);

        //    // Stocks - Prix d'achat
        //    modelBuilder.Entity<Stock>()
        //        .Property(s => s.PrixAchat)
        //        .HasPrecision(10, 2);

        //    // Expéditions - Poids
        //    modelBuilder.Entity<Expedition>()
        //        .Property(e => e.Poids)
        //        .HasPrecision(8, 2);

        //    // Factures - Montants
        //    modelBuilder.Entity<Facture>()
        //        .Property(f => f.PrixUnitaire)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<Facture>()
        //        .Property(f => f.MontantHT)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<Facture>()
        //        .Property(f => f.TVA)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<Facture>()
        //        .Property(f => f.MontantTTC)
        //        .HasPrecision(10, 2);
        //}

    }
}
