using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Interfaces
{
    public interface IServicioPatrones
    {

		//Crea tipos de cepillado


		//asigna zonas a tipos de cepillado


		//crea patrones_referencias ( tipos y sus zonas con datos de sensores)

		//asigna patrones_referencia a niños

		//metodo para analizar patrones de cepillado
		int AnalizarPatronesCepillado(byte[] patron1,byte[] patron2);

		//Gestiona sessiones de cepillado ( escucha, compara, analiza, guarda resultados)

	}
}
