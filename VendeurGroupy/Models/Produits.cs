using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeurGroupy.Models
{
    [Table("produit")]
    class Produits
    {
        [Column("id_produit")]
        public int id_produit { get; set; }

        [Column("id_categorie")]
        public int id_categorie { get; set; }

        [Column("description")]
        public string description {get; set;}

        [Column("prix")]
        public decimal prix { get; set; }

        [Column("image")]
        public string image { get; set; }

        [Column("id_vendeur")]
        public int id_vendeur { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

        [ForeignKey("id_categorie")]
        public virtual Categories Id_categorie { get; set; }

        [ForeignKey("id_vendeur")]
        public virtual Vendeurs Id_vendeur { get; set; }

    }
}
