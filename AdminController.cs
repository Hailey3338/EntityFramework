using System;

using System.Collections.Generic;

using System.Data;

using System.Data.SqlClient;

using System.Diagnostics;

using System.Dynamic;

using System.Linq;

using System.Web;

using System.Web.Mvc;

using WebApplication4.Models;

namespace EntityFrameworkWeb.Controllers

{
  public class AdminController : Controller
  {
        private IWorkerRepository workerRepository;
		public AdminController(){
		   this.workerRepository = new IWorkerRepository(new XingEntities());
		}
		public WorkerRepository(IWorkerRepository workerRepository)
		{
		   this.workerRepository = workerRepository;
		}
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
	    [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users objUser)
        {
            if (ModelState.IsValid)
            {
                using (XingEntities db= new XingEntities())
                {
                    var obj = db.Users.Where(a => a.user_name.Equals(objUser.user_name) && a.user_password.Equals(objUser.user_password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["isLogin"] = true;
                        Session["user_id"] = obj.user_id;
                        Session["user_name"] = obj.user_name.ToString();
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(objUser);
        }
		[HttpGet]
		public ViewResult WorkerInfoManagement()
		{
		   var workers = from s in workerRepository.GetWorkers() select s;
		   return View(workers);
		}
		[HttpGet]
		public ActionResult Delete(int id){
		   try{
		      Worker worker = workerRepository.GetById(id);
			  workRepository.DeleteWorker(id);
			  studentRepository.SaveChanges();
		   }
		   catch(DataException)
		   {
		      return RedirectToAction("Delete", new { id = id, saveChangesError = true });
		   }
		   return RedirectToAction("Index");
		}
		protected override void Dispose(bool disposing)
        {
         studentRepository.Dispose();
         base.Dispose(disposing);
        }

		   
  }
}
