using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendeurGroupy.Models
{
    [Table("factures")]
    [PrimaryKey("Id_facture")]

    class Facture
    {
        [Column("id_facture")]
        public int Id_facture { get; set; }

        [Column("date_facture")]
        public DateTime date_facture { get; set; }

        [Column("pdf_facture")]
        public string pdf_facture { get; set; }

        [Column("montantTTC")]
        public decimal montantTTC { get; set; }

        [Column("TVA")]
        public decimal TVA { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

        [Column("id_prevente")]
        public int Id_prevente { get; set; }

        [Column("id_vendeur")]
        public int Id_vendeur { get; set; }

        [Column("id_user")]
        public int Id_user { get; set; }

        [Column("id_produit")]
        public int Id_produit { get; set; }

        [Column("prix_initial")]
        public decimal prix_initial { get; set; }




        [ForeignKey("id_prevente")]
        public virtual Preventes Preventes { get; set; }

        [ForeignKey("id_vendeur")]
        public virtual Vendeurs Vendeurs { get; set; }


        [ForeignKey("id_user")]
        public virtual Clients Clients { get; set; }

        [ForeignKey("id_produit")]
        public virtual Produits Produits { get; set; }


    }
}
