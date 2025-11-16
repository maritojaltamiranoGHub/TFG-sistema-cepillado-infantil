using Sistema.Cepillado.Dominio.Interfaces;
using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Infraestructura.Repositorios
{
    public class RepositorioSesion : IRepositorioSesion
    {
        public Task AgregarAsync(Sesion sesion)
        {
            throw new NotImplementedException();
        }

        public Task<Sesion?> ObtenerPorIdAsync(int sesionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Sesion>> ObtenerPorNinoIdAsync(int ninoId)
        {
            throw new NotImplementedException();
        }
    }
}
