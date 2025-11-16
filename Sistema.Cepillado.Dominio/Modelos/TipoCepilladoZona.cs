using SQLite;
using System;
using System.Collections.Generic;

using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{
    [Table("tipos_cepillados_zonas")]
    public class TipoCepilladoZona
    {
        [PrimaryKey]
        [Column("id_tipo_cepillado")]
		public int TipoCepilladoId { get; set; }
        [PrimaryKey]
        [Column("id_zona")]
        public int ZonaDentalId { get; set; }
	}
}
