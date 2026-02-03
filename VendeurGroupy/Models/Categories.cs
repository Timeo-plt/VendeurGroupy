using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace VendeurGroupy.Models
{
    [Table("categories")]
    [PrimaryKey("Id_categorie")]

    class Categories
    {
        [Column("id_categorie")]
        public int Id_categorie { get; set; }

        [Column("id_gestionnaire")]
        public int Id_gestionnaire { get; set; }

        [Column("lib")]
        public string lib { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("id_gestionnaire")]
        public virtual Gestionnaire Gestionnaire { get; set; }

    }
}
