using Sistema.Cepillado.Dominio.Interfaces;
using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Infraestructura.Repositorios
{
    public class RepositorioTipoCepillado : IRepositorioTipoCepillado
    {
        public Task ActualizarAsync(TipoCepillado tipoCepillado)
        {
            throw new NotImplementedException();
        }

        public Task AgregarAsync(TipoCepillado tipoCepillado)
        {
            throw new NotImplementedException();
        }

        public Task<TipoCepillado?> ObtenerPorIdAsync(int tipoCepilladoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoCepillado>> ObtenerPorTutorIdAsync(int tutorId)
        {
            throw new NotImplementedException();
        }
    }
}
