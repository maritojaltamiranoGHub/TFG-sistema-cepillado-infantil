using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{
    [Table("tipos_cepillados")]
    public class TipoCepillado
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
		public int Id { get; set; }
        [Column("nombre")]
		public string Nombre { get; set; }
        [Column("id_tutor")]
		public int TutorId  { get; set; }
        
	}
}
