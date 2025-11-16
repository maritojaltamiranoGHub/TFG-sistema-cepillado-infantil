using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Interfaces
{
    public interface IRepositorioTipoCepillado
    {
		Task<TipoCepillado?> ObtenerPorIdAsync(int tipoCepilladoId); 
		/// <summary>///
		/// Obtiene todas las plantillas de tipo de cepillado creadas por un tutor.
		/// </summary>
		 
		
		Task<IEnumerable<TipoCepillado>> ObtenerPorTutorIdAsync(int tutorId);
		Task AgregarAsync(TipoCepillado tipoCepillado);
		Task ActualizarAsync(TipoCepillado tipoCepillado); // Para añadir/quitar zonas
	}
}
