using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public interface IWorkerRepository<Worker> where Worker : class
	{
		Worker GetById(int id);
		IQueryable<Worker> GetAll();
		void Insert(Worker worker);
		void Delete(Worker worker);
		void SaveChanges();
	}
}
