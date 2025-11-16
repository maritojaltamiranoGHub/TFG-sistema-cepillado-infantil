using Sistema.Cepillado.Dominio.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Infraestructura.DB
{
    public class DBManager : IDBManager
    {


        private SQLiteAsyncConnection _db;

        public DBManager(string dbPath, string passwd)
        {
			var options = new SQLiteConnectionString(dbPath, true, key: passwd);

            _db =  new SQLiteAsyncConnection(options);
		}

		public SQLiteAsyncConnection DevolverConexion()
        {
            
            return _db;
		}

		~DBManager()
        {
            _db.CloseAsync();
		}


	}
}
