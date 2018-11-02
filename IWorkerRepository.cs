using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public interface IWorkerRepository<Worker>
	{
		void Insert(Worker worker);
		void Delete(Worker worker);
		IQueryable<Worker> SearchFor(Express<Func<worker.bool>>predicate);
		IQueryable<Worker> GetAll();
		Worker GetById(int WorkerID);
		void SaveChanges();
	}
}
