using System.ComponentModel.DataAnnotations;

namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class EditarPerfilTutorViewModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "El nombre es obligatorio.")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El email es obligatorio.")]
		[EmailAddress(ErrorMessage = "El formato del email no es válido.")]
		public string Email { get; set; }

		// Las contraseñas son opcionales. Si el usuario las deja en blanco, no se cambian.
		
		[MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
		[RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()-+_]).*$", ErrorMessage = "La contraseña debe contener: una mayúscula, un número y un carácter especial (!@#$%^&*()-+_).")]
		public string? NuevaContrasena { get; set; }

		[Compare(nameof(NuevaContrasena), ErrorMessage = "Las contraseñas nuevas no coinciden.")]
		public string? ConfirmarNuevaContrasena { get; set; }


	}
}

