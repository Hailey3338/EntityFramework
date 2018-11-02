using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public interface IWorkerRepository<Worker>
	{
	        IEnumerable<Worker> GetWorkers();
		Worker GetWorkerById(int id);
		/*IQueryable<Worker> GetAll();*/
		void InsertWorker(Worker entity);
		void DeleteWorker(Worker entity);
		void UpdateWorker(Worker entity);
		void SaveChanges();
	}
}
