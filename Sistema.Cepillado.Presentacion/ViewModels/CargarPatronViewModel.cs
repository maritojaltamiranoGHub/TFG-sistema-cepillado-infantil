using Microsoft.AspNetCore.Components.Forms;

namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class CargarPatronViewModel
	{
		public int PerfilNinoId { get; set; }
		public List<ZonaDental> Zonas { get; set; }
		public int IndiceZonaActual { get; set; }
		public ZonaDental ZonaActual => Zonas[IndiceZonaActual];

		public IBrowserFile? ArchivoGiroscopio { get; set; }
		public IBrowserFile? ArchivoAcelerometro { get; set; }

		public bool EstaCompleto => IndiceZonaActual >= Zonas.Count;

		public CargarPatronViewModel()
		{
			Zonas = new List<ZonaDental>();
			IndiceZonaActual = 0;
		}
	}

	public class ZonaDental
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Imagen { get; set; } // Ruta a la imagen de la dentadura con esta zona resaltada
	}
}
