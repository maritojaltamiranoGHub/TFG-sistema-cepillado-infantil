namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class ReporteViewModel
	{
		public int EfectividadGeneral { get; set; }
		public Dictionary<string, EstadoCobertura> CoberturaZonas { get; set; } // La propiedad traducida
		public TimeSpan DuracionTotal { get; set; }
		public DateOnly FechaReporte { get; set; }

		public ReporteViewModel()
		{
			CoberturaZonas = new Dictionary<string, EstadoCobertura>();
		}
	}

	public enum EstadoCobertura
	{
		Optima,
		Mejorable,
		Insuficiente
	}
}