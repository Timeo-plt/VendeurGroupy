using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendeurGroupy.Models
{
    [Table("client")]
    [PrimaryKey("Id_user")]

    class Clients
    {
        [Column("id_user")]
        public int Id_user { get; set; }

        [ForeignKey("Id_user")] 
        public Utilisateurs Utilisateur { get; set; }
    }
}
