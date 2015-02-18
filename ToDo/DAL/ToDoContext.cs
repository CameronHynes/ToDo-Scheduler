using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ToDo.Models;

namespace ToDo.DAL
{
    public class ToDoContext : DbContext
    {
        public ToDoContext() : base("ToDoContext")
        {

        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}