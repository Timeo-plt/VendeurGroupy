using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendeurGroupy.Models
{
    [Table("gestionnaire")]
    [PrimaryKey("Id_gestionnaire")]

    internal class Gestionnaire
    {
        [Column("id_gestionnaire")]
        public int Id_gestionnaire { get; set; }

    }
}
