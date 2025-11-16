using Isopoh.Cryptography.Argon2;
using Sistema.Cepillado.Dominio.Interfaces;
using Sistema.Cepillado.Dominio.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Cepillado.Infraestructura.Repositorios
{
    public class RepositorioTutor : IRepositorioTutor
    {

        private SQLiteAsyncConnection _db;

        public RepositorioTutor(IDBManager dbm)
        {
            _db = dbm.DevolverConexion();

			_db.CreateTableAsync<Tutor>();

			_db.CreateTableAsync<Nino>();
		}


		//Padres
		public bool RegistrarTutor(Tutor tutor)
		{
			tutor.Password = Argon2.Hash(tutor.Password);

			//si el resultado es 0, no se inserto
			int result = 0;
			//creamos una transaccion para esta operacion
			 _db.RunInTransactionAsync(trans => {
				// database calls inside the transaction
				//si el resultado es 0, no se inserto
				result = trans.Insert(tutor);
			}).Wait();
						
            if (result == 0)
                return false;
			return true;
		}
		public async Task<Tutor?> LoginTutor(string email, string password)
		{
            Tutor tutor = await ObtenerPorEmailAsync(email);


            //validamos usando Argon2
            if (tutor == null || !Argon2.Verify(tutor.Password, password))
            {
                return null;
			}

			return tutor;
		}

		public async Task<Tutor?> ObtenerPorEmailAsync(string email)
		{
			//aca obtenemos el tutor por email
            var tutor = new Tutor();
            tutor =   _db.Table<Tutor>().Where(t => t.Email == email).FirstOrDefaultAsync().Result;
            return tutor;
			
		}
		Task<Tutor> IRepositorioTutor.ObtenerTutorPorId(int tutorId)
		{
			throw new NotImplementedException();
		}

		

		public bool ActualizarTutor(Tutor tutor)
        {
			//he notado que si no mandas un dato actualizado, lo pone en null !!!!!! 15/11/2025

			//hacemos el hash de la contraseña antes de actualizar
			tutor.Password = Argon2.Hash(tutor.Password);

			//si el resultado es 0, no se inserto
			int result = 0;
			//creamos una transaccion para esta operacion
			_db.RunInTransactionAsync(trans => {
				// database calls inside the transaction
				//si el resultado es 0, no se inserto
				result = trans.Update(tutor);
			}).Wait();

			if (result == 0)
				return false;
			return true;

		}

		
		public bool CrearNinoParaTutor(Nino nino, int tutorId)
        {
			nino.TutorId = tutorId;
			//si el resultado es 0, no se inserto
			int result = 0;
			//creamos una transaccion para esta operacion
			_db.RunInTransactionAsync(trans => {
				// database calls inside the transaction
				//si el resultado es 0, no se inserto
				result = trans.Insert(nino);
			}).Wait();

			if (result == 0)
				return false;
			return true;
		}

		//Niños
		public List<Nino> ObtenerNinosPorTutor(int TutorId)
		{
			//aca obtenemos el listado de niños por tutor
			return _db.Table<Nino>().Where(n => n.TutorId == TutorId).ToListAsync().Result;

		}

		public async Task<Nino> ObtenerNinoPorId(int ninoId)
        {
			//aca obtenemos el perfil del niño por id
			return  await _db.Table<Nino>().Where(n => n.Id == ninoId).FirstOrDefaultAsync();

		}

        public bool ActualizarNino(Nino nino)
        {
			
			//si el resultado es 0, no se inserto
			int result = 0;
			//creamos una transaccion para esta operacion
			_db.RunInTransactionAsync(trans => {
				// database calls inside the transaction
				//si el resultado es 0, no se inserto
				result = trans.Update(nino);
			}).Wait();

			if (result == 0)
				return false;
			return true;
		}
    }
}
