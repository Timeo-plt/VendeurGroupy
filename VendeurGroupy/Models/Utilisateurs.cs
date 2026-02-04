using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VendeurGroupy.Models
{
    [Table("utilisateur")]
    [PrimaryKey("Id_user")]
    public class Utilisateurs
    {
        [Column("id_user")]
        public int Id_user { get; set; }

        [Column("nom")]
        public string Nom { get; set; }

        [Column("prenom")]
        public string prenom { get; set; }

        [Column("adresse")]
        public string adresse { get; set; }

        [Column("phone")]
        public string phone { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("motdepasse")]
        public string mot_de_passe { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }



    }
}
