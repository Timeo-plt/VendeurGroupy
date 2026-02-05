using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VendeurGroupy.Models
{
    [Table("produit")]
    [PrimaryKey("Id_produit")]

    class Produits
    {
        [Column("id_produit")]
        public int Id_produit { get; set; }

        [Column("id_categorie")]
        public int Id_categorie { get; set; }

        [Column("description")]
        public string description {get; set;}

        [Column("prix")]
        public decimal prix { get; set; }

        [Column("image")]
        public string image { get; set; }

        [Column("id_vendeur")]
        public int id_vendeur { get; set; }

        [Column("prix_initial")]
        public decimal prix_initial { get; set; }

        [Column("prix_groupe")]
        public decimal prix_groupe { get; set; }

        [Column("id_prevente")]
        public int id_prevente { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

        [ForeignKey("id_categorie")]
        public virtual Categories Categories { get; set; }

        [ForeignKey("id_vendeur")]
        public virtual Vendeurs Vendeurs { get; set; }

        [ForeignKey("id_prevente")]
        public virtual Preventes Preventes { get; set; }

    }
}
