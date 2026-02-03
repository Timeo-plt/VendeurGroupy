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
        public int id_facture { get; set; }

        [Column("date_facture")]
        public DateTime date_facture { get; set; }

        [Column("pdf_facture")]
        public string pdf_facture { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }


    }
}
