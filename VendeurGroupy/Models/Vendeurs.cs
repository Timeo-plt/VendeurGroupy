using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeurGroupy.Models
{
    [Table("vendeur")]
    class Vendeurs
    {
        [Column("id_vendeur")]
        public int id_user { get; set; }

        [Column("nom_entreprise")]
        public string nom_entreprise { get; set; }

        [Column("adresse_entreprise")]
        public string adresse_entreprise { get; set; }

        [Column("email_pro")]
        public string email_pro { get; set; }  

    }
}
