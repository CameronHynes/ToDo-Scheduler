namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WorkerID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Worker", t => t.WorkerID)
                .Index(t => t.WorkerID);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DeadLine = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Schedule_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Schedule", t => t.Schedule_ID)
                .Index(t => t.Schedule_ID);
            
            CreateTable(
                "dbo.Worker",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedule", "WorkerID", "dbo.Worker");
            DropForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule");
            DropIndex("dbo.Task", new[] { "Schedule_ID" });
            DropIndex("dbo.Schedule", new[] { "WorkerID" });
            DropTable("dbo.Worker");
            DropTable("dbo.Task");
            DropTable("dbo.Schedule");
        }
    }
}
