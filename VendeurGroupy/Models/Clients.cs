using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendeurGroupy.Models
{
    [Table("clients")]
    [PrimaryKey("Id_client")]

    class Clients
    {
        [Column("id_client")]
        public int id_client { get; set; }

        [Column("nom")]
        public string nom { get; set; }

        [Column("prenom")]
        public string prenom { get; set; }

        [Column("adresse")]
        public string adresse { get; set; }

        [Column("phone")]
        public string phone { get; set; }

        [Column("email")]
        public string email { get; set; }
        [Column("motdepasse")]
        public string motdepasse { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }
        [Column("updated_at")]
        public DateTime updated_at { get; set; }
    }
}
