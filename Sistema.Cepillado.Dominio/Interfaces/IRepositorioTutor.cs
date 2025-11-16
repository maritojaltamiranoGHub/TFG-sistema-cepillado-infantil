using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Cepillado.Dominio.Interfaces
{
    public interface IRepositorioTutor
    {
		//Con esta Interfce administramos los tutores y sus niños

		bool RegistrarTutor(Tutor tutor);
		Task<Tutor?> LoginTutor(string email, string password);
		Task<Tutor> ObtenerTutorPorId(int tutorId);
		Task<Tutor?> ObtenerPorEmailAsync(string email);

		bool ActualizarTutor(Tutor tutor);


		//Niños
		bool CrearNinoParaTutor(Nino nino, int tutorId);
		Task<Nino> ObtenerNinoPorId(int ninoId);
		List<Nino> ObtenerNinosPorTutor(int TutorId);
		bool ActualizarNino(Nino nino);
	}


}
