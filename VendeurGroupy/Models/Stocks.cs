using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendeurGroupy.Models
{
    [Table("stocks")]
    [PrimaryKey("Id_stock")]

    class Stocks
    {
        [Column("id_stock")]
        public int Id_stock { get; set; }

        [Column("id_produit")]
        public int Id_produit { get; set; }

        [Column("stock_physique")]
        public int stock_physique { get; set; }

        [Column("stock_reserve")]
        public int stock_reserve { get; set; }

        [Column("seuil_alerte")]
        public int seuil_alerte { get; set; }

        [Column("prix_achat")]
        public decimal? prix_achat { get; set; }

        [Column("emplacement")]
        public string? emplacement { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

        [ForeignKey("Id_produit")]
        public virtual Produits? Produits { get; set; }

        [NotMapped]
        public int StockDisponible => stock_physique - stock_reserve;

        [NotMapped]
        public bool EnAlerte => stock_physique < seuil_alerte;

        [NotMapped]
        public decimal ValeurStock => stock_physique * (prix_achat ?? 0);

    }
}
