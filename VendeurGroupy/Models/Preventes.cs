using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VendeurGroupy.Models
{
    [Table("prevente")]
    [PrimaryKey("Id_prevente")]
    class Preventes
    {
        [Column("id_prevente")]
        public int Id_prevente { get; set; }

        [Column("date_limite")]
        public DateTime date_limite { get; set; }

        [Column("nombre_min")]
        public int nombre_min { get; set; }

        [Column("statut")]
        public string statut { get; set; }

        [Column("prix_prevente")]
        public decimal prix_prevente { get; set;}

        [Column("description")]
        public string decsription { get; set; }

        [Column("id_produit")]
        public int id_produit { get; set; }

        [Column("id_client")]
        public int id_client { get; set;}

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

        [ForeignKey("id_produit")]
        public virtual Produits Produits { get; set; }

        [ForeignKey("id_client")]
        public virtual Clients Clients { get; set; }

    }
}
