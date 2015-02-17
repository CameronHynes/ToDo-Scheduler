namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyConstraintBetweenScheduleAndWorker : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule");
            DropIndex("dbo.Schedule", new[] { "Worker_ID" });
            RenameColumn(table: "dbo.Task", name: "Schedule_ID", newName: "Schedule_WorkerID");
            RenameColumn(table: "dbo.Schedule", name: "Worker_ID", newName: "WorkerID");
            RenameIndex(table: "dbo.Task", name: "IX_Schedule_ID", newName: "IX_Schedule_WorkerID");
            DropPrimaryKey("dbo.Schedule");
            AlterColumn("dbo.Schedule", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Schedule", "WorkerID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Schedule", "WorkerID");
            CreateIndex("dbo.Schedule", "WorkerID");
            AddForeignKey("dbo.Task", "Schedule_WorkerID", "dbo.Schedule", "WorkerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "Schedule_WorkerID", "dbo.Schedule");
            DropIndex("dbo.Schedule", new[] { "WorkerID" });
            DropPrimaryKey("dbo.Schedule");
            AlterColumn("dbo.Schedule", "WorkerID", c => c.Int());
            AlterColumn("dbo.Schedule", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Schedule", "ID");
            RenameIndex(table: "dbo.Task", name: "IX_Schedule_WorkerID", newName: "IX_Schedule_ID");
            RenameColumn(table: "dbo.Schedule", name: "WorkerID", newName: "Worker_ID");
            RenameColumn(table: "dbo.Task", name: "Schedule_WorkerID", newName: "Schedule_ID");
            CreateIndex("dbo.Schedule", "Worker_ID");
            AddForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule", "ID");
        }
    }
}
