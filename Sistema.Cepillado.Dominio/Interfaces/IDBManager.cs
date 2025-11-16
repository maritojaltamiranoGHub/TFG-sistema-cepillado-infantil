using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Dominio.Interfaces
{
	public interface IDBManager
	{

		//metodo que devuelva la base de datos que el repositorio va usar
		//es una clase de soporte a los repositorios
		SQLiteAsyncConnection DevolverConexion();

	}
}
