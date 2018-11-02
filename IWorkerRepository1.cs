using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public interface IWorkerRepository
	{
		object GetById(int id);
		IQueryable GetAll();
		void Insert(object worker);
		void Delete(object worker);
		void SaveChanges();
	}
}
