

namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class PerfilNinoViewModel
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string UrlAvatar { get; set; }
		public DateTime? FechaNacimiento { get; set; }

		public int EdadAños
		{
			get
			{
				if (!FechaNacimiento.HasValue)
				{
					return 0; // O un valor indicando que no hay fecha.
				}

				var hoy = DateTime.Today;
				var fechaNac = FechaNacimiento.Value;

				// Calcula la edad inicial restando los años
				var edad = hoy.Year - fechaNac.Year;

				// Resta 1 si el cumpleaños aún no ha pasado este año
				if (fechaNac.Date > hoy.AddYears(-edad))
				{
					edad--;
				}

				return edad;
			}
		}
	}
}
