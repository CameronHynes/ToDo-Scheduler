namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedSchedules : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule");
            DropForeignKey("dbo.Schedule", "Worker_ID", "dbo.Worker");
            DropIndex("dbo.Schedule", new[] { "Worker_ID" });
            DropIndex("dbo.Task", new[] { "Schedule_ID" });
            AlterColumn("dbo.Task", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Task", "Schedule_ID");
            DropTable("dbo.Schedule");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Worker_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Task", "Schedule_ID", c => c.Int());
            AlterColumn("dbo.Task", "Description", c => c.String());
            CreateIndex("dbo.Task", "Schedule_ID");
            CreateIndex("dbo.Schedule", "Worker_ID");
            AddForeignKey("dbo.Schedule", "Worker_ID", "dbo.Worker", "ID");
            AddForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule", "ID");
        }
    }
}
