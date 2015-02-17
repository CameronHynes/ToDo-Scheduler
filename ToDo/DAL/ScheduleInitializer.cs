using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ToDo.Models;

namespace ToDo.DAL
{
    public class ScheduleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ToDoContext>
    {
        protected override void Seed(ToDoContext context)
        {
            //base.Seed(context);

            var workers = new List<Worker>
            {
                new Worker{Name="Worker1"},
                new Worker{Name="Worker2"},
                new Worker{Name="Worker3"},
                new Worker{Name="Worker4"},
                new Worker{Name="Worker5"},
                new Worker{Name="Worker6"},
                new Worker{Name="Worker7"},
                new Worker{Name="Worker8"},
                new Worker{Name="Worker9"},
                new Worker{Name="Worker10"},
                new Worker{Name="Worker11"},
                new Worker{Name="Worker12"},
                new Worker{Name="Worker13"},
                new Worker{Name="Worker14"},
                new Worker{Name="Worker15"},
            };

            workers.ForEach(s => context.Workers.Add(s));
            context.SaveChanges();


            var tasks = new List<Task>
            {
                new Task
                {
                    Description = "1",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 1, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 34, 0)
                },
                new Task
                {
                    Description = "2",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 2, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 25, 0)
                },
                new Task
                {
                    Description = "3",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 4, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 21, 0)
                },
                new Task
                {
                    Description = "4",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 4, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 19, 0)
                },
                new Task
                {
                    Description = "5",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 8, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 22, 0)
                },
                new Task
                {
                    Description = "6",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 16, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 35, 0)
                },
                new Task
                {
                    Description = "7",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 16, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 34, 0)
                },
                new Task
                {
                    Description = "8",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 17, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 45, 0)
                },
                new Task
                {
                    Description = "9",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 20, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 37, 0)
                },
                new Task
                {
                    Description = "10",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 22, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 55, 0)
                },
                new Task
                {
                    Description = "11",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 26, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 40, 0)
                },
                new Task
                {
                    Description = "12",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 22, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 44, 0)
                },
                new Task
                {
                    Description = "13",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 31, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 42, 0)
                },
                new Task
                {
                    Description = "14",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 35, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 59, 0)
                },
                new Task
                {
                    Description = "15",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 39, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 49, 0)
                },
                new Task
                {
                    Description = "16",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 39, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 4, 0)
                },
                new Task
                {
                    Description = "17",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 40, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 5, 0)
                },
                new Task
                {
                    Description = "18",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 43, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 5, 0)
                },
                new Task
                {
                    Description = "19",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 47, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 3, 0)
                },
                new Task
                {
                    Description = "20",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 47, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 4, 0)
                },
                new Task
                {
                    Description = "21",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 50, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 7, 0)
                },
                new Task
                {
                    Description = "22",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 51, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 16, 0)
                },
                new Task
                {
                    Description = "23",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 51, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 4, 0)
                },
                new Task
                {
                    Description = "24",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 52, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 17, 0)
                },
                new Task
                {
                    Description = "25",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 54, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 16, 0)
                },
                new Task
                {
                    Description = "26",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 57, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 18, 0)
                }
            };
            tasks.ForEach(s => context.Tasks.Add(s));
            context.SaveChanges();




        }
    }
}