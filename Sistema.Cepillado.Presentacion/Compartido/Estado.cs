using Sistema.Cepillado.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Presentacion.Compartido
{
	public static class Estado 
	{
		
		private static Tutor? _tutorActivo;
		private static Nino? _ninoActivo;

		
		public static Tutor? GetTutorActivo()
		{
			return _tutorActivo;
		}

		
		public static void SetTutorActivo(Tutor tutor)
		{
			
			_tutorActivo = tutor;
		}


		public static Nino? GetNinoActivo()
		{
			return _ninoActivo;
		}

		public static void SetNinoActivo(Nino nino)
		{
			_ninoActivo = nino;
		}

		// (RESET)
		public static void LimpiarEstado()
		{
			_tutorActivo = null;
			_ninoActivo = null;
		}
	}
}
