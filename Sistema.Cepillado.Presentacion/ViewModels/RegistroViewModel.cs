using System.ComponentModel.DataAnnotations;

namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class RegistroViewModel
	{
		[Required(ErrorMessage = "El nombre es obligatorio.")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El email es obligatorio.")]
		[EmailAddress(ErrorMessage = "El formato del email no es válido.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "La contraseña es obligatoria.")]
		[MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
		[RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()-+_]).*$",ErrorMessage = "La contraseña debe contener: una mayúscula, un número y un carácter especial (!@#$%^&*()-+_).")]
		public string Contrasena { get; set; }

		[Required(ErrorMessage = "Debes confirmar la contraseña.")]
		[Compare(nameof(Contrasena), ErrorMessage = "Las contraseñas no coinciden.")]
		public string ConfirmarContrasena { get; set; }
	}
}
