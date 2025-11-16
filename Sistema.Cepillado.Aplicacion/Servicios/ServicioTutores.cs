using Sistema.Cepillado.Dominio.Interfaces;
using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Aplicacion.Servicios
{
    public class ServicioTutores : IServicioTutores
    {

        private readonly IRepositorioTutor _repositorioTutor;
        public ServicioTutores(IRepositorioTutor repositorioTutor)
        {
            _repositorioTutor = repositorioTutor;
		}

		public Tutor RegistrarTutor(Tutor tutor)
		{
			bool tutorRegistrado;

			tutorRegistrado = _repositorioTutor.RegistrarTutor(tutor);

			if (tutorRegistrado)
			{
				return tutor;
			}
			else
			{
				return new Tutor();

			}
		}

		public async Task<Tutor?> LoginTutor(string email, string password)
        {

		
            return await _repositorioTutor.LoginTutor(email, password);

		}
		//busco el tutor por id
		public async Task<Tutor> ObtenerPerfilTutorPorId(int tutorId)
		{
			return await _repositorioTutor.ObtenerTutorPorId(tutorId);

		}

		public List<Nino> ObtenerNinosPorTutor(int tutorId)
        {
            return _repositorioTutor.ObtenerNinosPorTutor(tutorId);

		}

		public  Tutor ActualizarPerfilTutor(Tutor tutor)
		{
			//actualizo el perfil del tutor
			 
			bool tutorActualizado;

			tutorActualizado = _repositorioTutor.ActualizarTutor(tutor);

			if (tutorActualizado)
			{
				return tutor;
			}
			else
			{
				return new Tutor();

			}

		}

        
    }
}
