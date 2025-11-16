namespace Sistema.Cepillado.Presentacion.ViewModels
{
	public class PerfilesViewModel
	{
		public string NombreTutor { get; set; }
		public List<PerfilNinoViewModel> PerfilesNinos { get; set; }

		public PerfilesViewModel()
		{
			PerfilesNinos = new List<PerfilNinoViewModel>();
		}
	}
}
