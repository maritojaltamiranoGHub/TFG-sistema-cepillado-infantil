using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Modelos
{
    [Table("detalle_coberturas")]
    public class DetalleCobertura
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_sesion")]
        public int SesionId { get; set; }
        [Column("id_zona")]
		public int ZonaDentalId { get; set; }
        [Column("cobertura")]
        public int CoberturaPorZona { get; set; }
        [Column("tiempo_actividad")]
		public float TiempoActividadZona { get; set; }

	}
}
