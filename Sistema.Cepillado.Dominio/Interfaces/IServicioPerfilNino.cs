using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Interfaces
{
    public interface IServicioPerfilNino
    {

		

		//crear perfil del niño
		Nino CrearPerfilNino(Nino nino, Tutor tutor);

		//metodo para obtener el perfil del niño por su ID
		Task<Nino> ObtenerPerfilNinoPorId(int ninoId);
		//metodo para actualizar el perfil del niño
		Nino ActualizarPerfilNino(Nino nino);

		//metodo para eliminar el perfil del niño
		void EliminarPerfilNino(int ninoId);

		//mostrar utimo reporte dental
				//ReporteDental ObtenerUltimoReporteDental(int ninoId);
		//mostrar historial de reportes dentales
				//List<ReporteDental> ObtenerHistorialReportesDentales(int ninoId);
		
			
	}
}
