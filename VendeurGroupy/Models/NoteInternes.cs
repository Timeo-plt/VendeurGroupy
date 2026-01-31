using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeurGroupy.Models
{
    [Table("note_internes")]

    class NoteInternes
    {
        [Column("id_noteInterne")]
        public int id_noteInterne { get; set; }

        [Column("id_prevente")]
        public int id_prevente { get; set; }

        [Column("id_vendeur")]
        public int id_vendeur { get; set; }

        [Column("contenu")]
        public string contenu { get; set; }

        [Column("type_note")]
        public string type_note { get; set; }

        [Column("date_creation")]
        public DateTime date_creation { get; set; }

        [Column("created_at")]
        public DateTime created_at { get; set; }

        [Column("updated_at")]
        public DateTime updated_at { get; set; }




    }
}
