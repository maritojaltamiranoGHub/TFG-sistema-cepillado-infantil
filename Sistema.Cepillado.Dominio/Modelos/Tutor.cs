using SQLite;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{

	[Table("tutores")]
	
	public class Tutor
    {
		[PrimaryKey, AutoIncrement]
		[Column("id")]
		public int Id { get; set; }
		[Column("nombre")]
		public string Nombre { get; set; }
		[Column("apellido")]
		public string Apellido { get; set; }
		[Column("password")]
		public string Password { get; set; }
		[Column("email")]
		public string Email { get; set; }
    }

}