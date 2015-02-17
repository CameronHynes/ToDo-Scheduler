namespace ToDo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDo.DAL.ToDoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDo.DAL.ToDoContext context)
        {

            var workers = new List<Worker>
            {
                new Worker{Name="Worker1", ID=1},
                new Worker{Name="Worker2", ID=2},
                new Worker{Name="Worker3", ID=3},
                new Worker{Name="Worker4", ID=4},
                new Worker{Name="Worker5", ID=5},
                new Worker{Name="Worker6", ID=6},
                new Worker{Name="Worker7", ID=7},
                new Worker{Name="Worker8", ID=8},
                new Worker{Name="Worker9", ID=9},
                new Worker{Name="Worker10", ID=10},
                new Worker{Name="Worker11", ID=11},
                new Worker{Name="Worker12", ID=12},
                new Worker{Name="Worker13", ID=13},
                new Worker{Name="Worker14", ID=14},
                new Worker{Name="Worker15", ID=15},
            };

            workers.ForEach(s => context.Workers.AddOrUpdate(s));
            context.SaveChanges();


            var tasks = new List<Task>
            {
                new Task
                {
                    Description = "1",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 1, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 34, 0),
                    ID=1
                },
                new Task
                {
                    Description = "2",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 2, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 25, 0),
                    ID=2
                },
                new Task
                {
                    Description = "3",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 4, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 21, 0),
                    ID=3
                },
                new Task
                {
                    Description = "4",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 4, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 19, 0),
                    ID=4
                },
                new Task
                {
                    Description = "5",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 8, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 22, 0),
                    ID=5
                },
                new Task
                {
                    Description = "6",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 16, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 35, 0),
                    ID=6
                },
                new Task
                {
                    Description = "7",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 16, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 34, 0),
                    ID=7
                },
                new Task
                {
                    Description = "8",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 17, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 45, 0),
                    ID=8
                },
                new Task
                {
                    Description = "9",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 20, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 37, 0),
                    ID=9
                },
                new Task
                {
                    Description = "10",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 22, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 55, 0),
                    ID=10
                },
                new Task
                {
                    Description = "11",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 26, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 40, 0),
                    ID=11
                },
                new Task
                {
                    Description = "12",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 22, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 44, 0),
                    ID=12

                },
                new Task
                {
                    Description = "13",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 31, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 42, 0),
                    ID=13
                },
                new Task
                {
                    Description = "14",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 35, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 59, 0),
                    ID=14
                },
                new Task
                {
                    Description = "15",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 39, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 49, 0),
                    ID=15
                },
                new Task
                {
                    Description = "16",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 39, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 4, 0),
                    ID=16
                },
                new Task
                {
                    Description = "17",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 40, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 5, 0),
                    ID=17
                },
                new Task
                {
                    Description = "18",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 43, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 5, 0),
                    ID=18
                },
                new Task
                {
                    Description = "19",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 47, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 3, 0),
                    ID=19
                },
                new Task
                {
                    Description = "20",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 47, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 4, 0),
                    ID=20
                },
                new Task
                {
                    Description = "21",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 50, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 7, 0),
                    ID=21
                },
                new Task
                {
                    Description = "22",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 51, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 16, 0),
                    ID=22
                },
                new Task
                {
                    Description = "23",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 51, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 4, 0),
                    ID=23
                },
                new Task
                {
                    Description = "24",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 52, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 17, 0),
                    ID=24
                },
                new Task
                {
                    Description = "25",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 54, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 16, 0),
                    ID=25
                },
                new Task
                {
                    Description = "26",
                    StartTime = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 6, 57, 0),
                    DeadLine = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 7, 18, 0),
                    ID=26
                }
            };
            tasks.ForEach(s => context.Tasks.Add(s));
            context.SaveChanges();


        }
    }
}
