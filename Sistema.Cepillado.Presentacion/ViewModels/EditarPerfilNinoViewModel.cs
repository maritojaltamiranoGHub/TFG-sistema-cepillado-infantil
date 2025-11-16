using System.ComponentModel.DataAnnotations;

namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class EditarPerfilNinoViewModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "El nombre del niño es obligatorio.")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
		public DateTime? FechaNacimiento { get; set; }

		//aca podemos cargar la url del avatar seleccionado
		public string AvatarSeleccionado { get; set; }

		
	}
}