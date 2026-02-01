using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeurGroupy.Models
{
    [Table("gestionnaire")]
    internal class Gestionnaire
    {
        [Column("id_gestionnaire")]
        public int id_gestionnaire { get; set; }

    }
}
