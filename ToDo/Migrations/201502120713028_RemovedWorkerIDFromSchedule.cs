namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedWorkerIDFromSchedule : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Schedule", name: "WorkerID", newName: "Worker_ID");
            RenameIndex(table: "dbo.Schedule", name: "IX_WorkerID", newName: "IX_Worker_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Schedule", name: "IX_Worker_ID", newName: "IX_WorkerID");
            RenameColumn(table: "dbo.Schedule", name: "Worker_ID", newName: "WorkerID");
        }
    }
}
