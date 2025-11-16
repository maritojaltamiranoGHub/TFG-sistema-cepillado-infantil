using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Interfaces
{
    public interface IServicioTutores
    {
		//metodo de registro
		Tutor RegistrarTutor(Tutor tutor);

		//metodo de login
		Task<Tutor?> LoginTutor(string email, string password);

		//verificar
		List<Nino> ObtenerNinosPorTutor(int tutorId);

		Task<Tutor> ObtenerPerfilTutorPorId(int tutorId);

		//actualizacion de datos de usuario (tutor)

		Tutor ActualizarPerfilTutor(Tutor tutor);
		//Crear tipos de cepillado

		//asignar zonas a tipos de cepillado

		//crear patrones_referncias

		//asignar patrones_referencia a niños


	}
}
