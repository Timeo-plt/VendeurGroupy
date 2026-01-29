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
    }
}
