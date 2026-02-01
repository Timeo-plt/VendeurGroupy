using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeurGroupy.Models
{
    [Table("stocks")]
    class Stocks
    {
        [Column("id_stock")]
        public int id_stock { get; set; }

        [Column("id_produit")]
        public int id_produit { get; set; }

        [Column("stock_physique")]
        public int stock_physique { get; set; }

        [Column("stock_reserve")]
        public int stock_reserve { get; set; }

        [Column("seuil_alerte")]
        public int seuil_alerte { get; set; }

        [Column("prix_achat")]
        public decimal prix_achat { get; set; }

        [Column("emplacement")]
        public string emplacement { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

        [ForeignKey("id_produit")]
        public virtual Produits Id_produit { get; set; }

        [NotMapped]
        public int StockDisponible => stock_physique - stock_reserve;

        [NotMapped]
        public bool EnAlerte => stock_physique < seuil_alerte;

        [NotMapped]
        public decimal ValeurStock => stock_physique * (prix_achat  ?? 0);

    }
}
