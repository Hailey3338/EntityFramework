using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public class WorkerRepository : IWorkerRepository<Worker>
	{
	   Model1 _context;
	   public WorkerRepository()
	   {
	      _context = new Model1();
	   }
	   public IEnumerable<Worker> List
	   {
	      get 
		  {
		     return _context.Workers;
		  }
	   }
	   public void Add(Worker entity)
	   {
	      _context.Workers.Add(entity);
		  _context.SaveChanges();
	   }
	   public void Delete(int id)
	   {
	      var entity = _context.Worker.Find(id);
	      _context.Worker.Remove(entity);
		  _context.SaveChanges();
	   }
	   public void Update(Worker entity)
	   {
	      _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
		  _context.SaveChanges();
	   }
	   public Worker GetById(int id)
	   {
	      var result = (from r in _context.Worker where r.WorkerID = id select r).FirstOrDefault();
		  return result;
	   }
	}
}
