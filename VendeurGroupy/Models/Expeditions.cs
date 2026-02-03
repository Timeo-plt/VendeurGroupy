using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendeurGroupy.Models
{
    [Table("expeditions")]
    [PrimaryKey("Id_expedition")]

    class Expeditions
    {
        [Column("id_expedition")]
        public int id_expedition { get; set; }

        [Column("id_prevente")]
        public int id_prevente { get; set; }

        [Column("numero_tracking")]
        public string numero_tracking { get; set; }
            
        [Column("transporteur")]
        public string transporteur { get; set; }

        [Column("statut")]
        public string statut { get; set; } = "en preparation";

        [Column("date_preparation")]
        public DateTime date_preparation { get; set; }

        [Column("date_expedition")]
        public DateTime date_expedtion { get; set; }

        [Column("date_livraison_prevue")]
        public DateTime date_livraison_prevue { get; set; }

        [Column("date_livraison_reelle")]
        public DateTime date_livraison_reelle { get; set; }

        [Column("poids")]
        public decimal poids { get; set; }

        [Column("dimensions")]
        public string dimensions { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }
        
        [ForeignKey("id_prevente")]
        public virtual Preventes Id_prevente { get; set; }
    }
}
