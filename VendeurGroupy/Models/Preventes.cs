using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeurGroupy.Models
{
    [Table("prevente")]
    class Preventes
    {
        [Column("id_prevente")]
        public int id_prevente { get; set; }

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

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }

    }
}
