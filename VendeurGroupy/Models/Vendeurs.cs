using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendeurGroupy.Models
{
    [Table("vendeur")]
    [PrimaryKey("Id_vendeur")]

    class Vendeurs
    {
        [Column("id_vendeur")]
        public int Id_vendeur { get; set; }

        [Column("nom_entreprise")]
        public string nom_entreprise { get; set; }

        [Column("adresse_entreprise")]
        public string adresse_entreprise { get; set; }

        [Column("email_pro")]
        public string email_pro { get; set; }  

    }
}
