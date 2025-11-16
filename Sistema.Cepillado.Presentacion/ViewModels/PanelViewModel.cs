namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class PanelViewModel
	{
		public PerfilNinoViewModel PerfilActual { get; set; }
		public UltimaSesionViewModel UltimaSesion { get; set; }
	}

	public class UltimaSesionViewModel
	{
		public int Efectividad { get; set; } 
		public DateOnly Fecha { get; set; }
		public TimeOnly DuracionEfectiva { get; set; }
	}
}