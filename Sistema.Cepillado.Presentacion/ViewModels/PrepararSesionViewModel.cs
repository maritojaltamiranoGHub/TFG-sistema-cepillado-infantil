using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis; // Necesario para el nuevo atributo

namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class PrepararSesionViewModel
	{
		public IBrowserFile? ArchivoGiroscopio { get; set; }

		public IBrowserFile? ArchivoAcelerometro { get; set; }
	}
}