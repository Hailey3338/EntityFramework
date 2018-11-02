using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public interface IWorkerRepository<Worker>
	{
	        IEnumerable<Worker> List {get;}
		Worker GetById(int id);
		/*IQueryable<Worker> GetAll();*/
		void Insert(Worker entity);
		void Delete(Worker entity);
		void Update(Worker entity);
		void SaveChanges();
	}
}
