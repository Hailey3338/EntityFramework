using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public class WorkerRepository : IWorkerRepository, IDisposable
	{
	   /*Model1 _context;
	   public WorkerRepository()
	   {
	      _context = new Model1();
	   }*/
	   private XingEntities _context;
	   public WorkerRepository(XingEntities context)
	   {
	      this.context = _context;
	   }
	   public IEnumerable<Worker> GetWorkers()
	   {
	      return _context.Workers.ToList();
	   }
	   public void AddWorker(Worker entity)
	   {
	      _context.Workers.Add(entity);
	      _context.SaveChanges();
	   }
	   public void DeleteWorker(int id)
	   {
	      var entity = _context.Worker.Find(id);
	      _context.Worker.Remove(entity);
		  _context.SaveChanges();
	   }
	   public void UpdateWorker(Worker entity)
	   {
	      _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
		  _context.SaveChanges();
	   }
	   public Worker GetById(int id)
	   {
	      Worker result = (from r in _context.Worker where r.WorkerID = id select r).FirstOrDefault();
		  return result;
	   }
	   private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

	}
}
