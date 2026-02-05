using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VendeurGroupy.Models
{
    [Table("signaler")]
    [PrimaryKey("Id_signal")]
    class Signalements
    {
        [Column("id_signal")]
        public int Id_signal { get; set; }

        [Column("id_user")]
        public int Id_user { get; set; }

        [Column("id_produit")]
        public int Id_produit { get; set; }

        [Column("date_signal")]
        public DateTime date_signal { get; set; }

        [ForeignKey("Id_produit")]
        public virtual Produits Produits { get; set;}

        [ForeignKey("Id_user")]
        public virtual Clients Clients { get; set; }

    }
}
