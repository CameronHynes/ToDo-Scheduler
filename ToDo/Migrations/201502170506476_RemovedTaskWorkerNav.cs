namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTaskWorkerNav : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Task", "Schedule_WorkerID", "dbo.Schedule");
            DropIndex("dbo.Schedule", new[] { "WorkerID" });
            RenameColumn(table: "dbo.Task", name: "Schedule_WorkerID", newName: "Schedule_ID");
            RenameColumn(table: "dbo.Schedule", name: "WorkerID", newName: "Worker_ID");
            RenameIndex(table: "dbo.Task", name: "IX_Schedule_WorkerID", newName: "IX_Schedule_ID");
            DropPrimaryKey("dbo.Schedule");
            AlterColumn("dbo.Schedule", "Worker_ID", c => c.Int());
            AlterColumn("dbo.Schedule", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Worker", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Schedule", "ID");
            CreateIndex("dbo.Schedule", "Worker_ID");
            AddForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule");
            DropIndex("dbo.Schedule", new[] { "Worker_ID" });
            DropPrimaryKey("dbo.Schedule");
            AlterColumn("dbo.Worker", "Name", c => c.String());
            AlterColumn("dbo.Schedule", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Schedule", "Worker_ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Schedule", "WorkerID");
            RenameIndex(table: "dbo.Task", name: "IX_Schedule_ID", newName: "IX_Schedule_WorkerID");
            RenameColumn(table: "dbo.Schedule", name: "Worker_ID", newName: "WorkerID");
            RenameColumn(table: "dbo.Task", name: "Schedule_ID", newName: "Schedule_WorkerID");
            CreateIndex("dbo.Schedule", "WorkerID");
            AddForeignKey("dbo.Task", "Schedule_WorkerID", "dbo.Schedule", "WorkerID");
        }
    }
}
