using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Interfaces
{
    public interface IRepositorioSesion
    {

		Task<Sesion?> ObtenerPorIdAsync(int sesionId);
		Task<IEnumerable<Sesion>> ObtenerPorNinoIdAsync(int ninoId);
		Task AgregarAsync(Sesion sesion);


	}
}
