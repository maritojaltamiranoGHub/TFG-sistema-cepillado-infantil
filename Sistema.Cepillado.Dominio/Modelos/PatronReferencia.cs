using SQLite;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{
    [Table("patrones_de_referencias")]
	public class PatronReferencia
    {
		[PrimaryKey, AutoIncrement]
        [Column("id")]
		public int Id { get; set; }
        [Column("id_tipo_cepillado")]
        public int TipoCepilladoId { get; set; }
        [Column("id_zona")]
		public int ZonaDentalId { get; set; }
        [Column("id_nino")]
		public int NinoId { get; set; }
        [Column("datos_serie_referencia")]
		public string DatosSerieReferencia { get; set; }

	}
}
