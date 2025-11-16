using Sistema.Cepillado.Dominio.Interfaces;
using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Aplicacion.Servicios
{
    public class ServicioPerfilNino : IServicioPerfilNino
    {

		private readonly IRepositorioTutor _repositorioTutor;
		public ServicioPerfilNino(IRepositorioTutor repositorioTutor)
		{
			_repositorioTutor = repositorioTutor;
		}


		public Nino ActualizarPerfilNino(Nino nino)
        {
			//actualizo el perfil del tutor

			bool ninoActualizado;

			ninoActualizado = _repositorioTutor.ActualizarNino(nino);

			if (ninoActualizado)
			{
				return nino;
			}
			else
			{
				return new Nino();

			}
		}

        public Nino CrearPerfilNino(Nino nino, Tutor tutor)
        {

			bool ninoRegistrado;

			ninoRegistrado = _repositorioTutor.CrearNinoParaTutor(nino, tutor.Id);

			if (ninoRegistrado)
			{
				return nino;
			}
			else
			{
				return new Nino();

			}

		}

        public void EliminarPerfilNino(int ninoId)
        {
            throw new NotImplementedException();
        }

        public Task<Nino> ObtenerPerfilNinoPorId(int ninoId)
        {
			//a travez del repositorio obtener el perfil del niño
			return  _repositorioTutor.ObtenerNinoPorId(ninoId);

		}

       
    }
}
