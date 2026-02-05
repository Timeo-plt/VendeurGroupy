using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VendeurGroupy.Models
{
    [Table("mouvements_stocks")]
    [PrimaryKey("Id_mouvementStock")]
    class MouvementStocks
    {
        [Column("id_mouvementStock")]
        public int Id_mouvementStock { get; set; }

        [Column("id_produit")]
        public int id_produit { get; set; }

        [Column("id_vendeur")]
        public int id_vendeur { get; set; }

        [Column("type_mouvement")]
        public string type_mouvement { get; set; }

        [Column("quantite")]
        public int quantite { get; set; }

        [Column("stock_avant")]
        public int stock_avant { get; set; }

        [Column("stock_apres")]
        public int stock_apres { get; set; }

        [Column("motif")]
        public string motif { get; set; }

        [Column("motif_detaille")]
        public string motif_detaille { get; set; }

        [Column("date_mouvement")]
        public DateTime date_mouvement { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

        [ForeignKey("id_produit")]
        public virtual Produits Produits { get; set; }

        [ForeignKey("id_vendeur")]
        public virtual Vendeurs Vendeurs { get; set; }

    }
}
