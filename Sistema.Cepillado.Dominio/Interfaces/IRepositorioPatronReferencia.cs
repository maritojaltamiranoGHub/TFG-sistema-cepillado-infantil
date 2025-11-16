using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Interfaces
{
    public interface IRepositorioPatronReferencia
    {
		Task<PatronReferencia?> ObtenerPorIdAsync(int patronId);
		/// <summary>/// Obtiene todos los patrones creados por un tutor (independientemente del niño)./// </summary>
		Task<IEnumerable<PatronReferencia>> ObtenerPorTutorIdAsync(Guid tutorId);
		/// <summary>/// Obtiene el patrón de referencia que está actualmente activo para un niño./// Esta es la función clave para el análisis de una sesión./// </summary>
		Task<PatronReferencia?> ObtenerActivoPorNinoIdAsync(int ninoId); 
		Task AgregarAsync(PatronReferencia patron);
		Task ActualizarAsync(PatronReferencia patron); // Para actualizar los datos de la serie
	}
}
