using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{
	
	[Table("zonas_dentales")]
	public  class ZonaDental
    {
		[PrimaryKey, AutoIncrement]
		[Column("id")]
		public int Id { get; set; }
		[Column("nombre")]
		public string Nombre { get; set; }
		[Column("imagen")]
		public string Imagen { get; set; }
	}
}
