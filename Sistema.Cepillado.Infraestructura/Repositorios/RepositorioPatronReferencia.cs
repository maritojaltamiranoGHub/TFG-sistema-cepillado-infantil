using Sistema.Cepillado.Dominio.Interfaces;
using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Infraestructura.Repositorios
{
    public class RepositorioPatronReferencia : IRepositorioPatronReferencia
    {
        public Task ActualizarAsync(PatronReferencia patron)
        {
            throw new NotImplementedException();
        }

        public Task AgregarAsync(PatronReferencia patron)
        {
            throw new NotImplementedException();
        }

        public Task<PatronReferencia?> ObtenerActivoPorNinoIdAsync(int ninoId)
        {
            throw new NotImplementedException();
        }

        public Task<PatronReferencia?> ObtenerPorIdAsync(int patronId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatronReferencia>> ObtenerPorTutorIdAsync(Guid tutorId)
        {
            throw new NotImplementedException();
        }
    }
}
