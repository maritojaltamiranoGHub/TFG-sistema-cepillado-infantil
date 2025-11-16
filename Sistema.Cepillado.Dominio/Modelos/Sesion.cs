using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{
    [Table("sesiones")]
    public class Sesion
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_nino")]
        public int NinoId { get; set; }
        [Column("id_tipo_cepillado")]
        public int TipoCepilladoId { get; set; }
        [Column("fecha_inicio")]
		public DateTime FechaInicio { get; set; }
        [Column("fecha_fin")]
		public DateTime FechaFin { get; set; }
        [Column("tiempo_efectivo")]
		public TimeOnly TiempoEfectivo { get; set; }
        [Column("cobertura")]
		public int Cobertura { get; set; }
	}
}
