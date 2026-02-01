using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeurGroupy.Models
{
    [Table("signaler")]
    class Signalements
    {
        [Column("id_signal")]
        public int id_signal { get; set; }

        [Column("id_user")]
        public int id_user { get; set; }

        [Column("id_produit")]
        public int id_produit { get; set; }

        [Column("date_signal")]
        public DateTime date_signal { get; set; }

        [ForeignKey("id_produit")]
        public virtual Produits Id_produit { get; set;}

    }
}
