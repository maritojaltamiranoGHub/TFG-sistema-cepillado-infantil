using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{
	[Table("ninos")]
	public class Nino
    {
		[PrimaryKey, AutoIncrement]
		[Column("id")]
		public int Id { get; set; }
		[Column("nombre")]
		public string Nombre { get; set; }
		[Column("apellido")]
		public string Apellido { get; set; }
		[Column("fecha_nacimiento")]
		public DateTime FechaNacimiento { get; set; } 

		[Column("id_tutor")]
		public int TutorId { get; set; }
		[Column("avatar")]
		public string Avatar { get; set; }
		[Column("id_tipo_Cepillado")]
		public int TipoCepilladoId { get; set; }

	}
}
