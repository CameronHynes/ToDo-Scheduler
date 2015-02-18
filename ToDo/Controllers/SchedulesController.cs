using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToDo.DAL;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class SchedulesController : Controller
    {
        private ToDoContext db = new ToDoContext();

        // GET: Generate schedules for each task, assign workers
        public ActionResult Index()
        {
            var schedules = new List<Schedule>();

            var tasks = db.Tasks.ToList();

            foreach (Task t in tasks)
            {
                bool taskAddedToExistingSchedule = false;

                foreach (Schedule s in schedules)
                {
                    taskAddedToExistingSchedule = s.TryAddTask(t);
                    if (taskAddedToExistingSchedule) break;
                }

                if (!taskAddedToExistingSchedule)
                {
                    Schedule newSchedule = new Schedule();
                    newSchedule.TryAddTask(t);
                    schedules.Add(newSchedule);
                    
                }
            }

            // Assign workers to schedules
            var workers = db.Workers.ToList();

            IEnumerator<Worker> workerEnum = workers.GetEnumerator();

            foreach (Schedule s in schedules)
            {
                if (workerEnum.MoveNext())
                {
                    s.Worker = workerEnum.Current;
                }

            }

            return View(schedules.ToList());
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
