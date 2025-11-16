using System.ComponentModel.DataAnnotations;

namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class CrearPerfilViewModel
	{
		[Required(ErrorMessage = "El nombre del niño es obligatorio.")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
		public DateTime FechaNacimiento { get; set; } = DateTime.Now;

		[Required(ErrorMessage = "Debes seleccionar un avatar.")]
		public string AvatarSeleccionado { get; set; }

	}
}
