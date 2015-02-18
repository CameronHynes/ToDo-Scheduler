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
                        Worker_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Worker", t => t.Worker_ID)
                .Index(t => t.Worker_ID);
            
            AddColumn("dbo.Task", "Schedule_ID", c => c.Int());
            CreateIndex("dbo.Task", "Schedule_ID");
            AddForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedule", "Worker_ID", "dbo.Worker");
            DropForeignKey("dbo.Task", "Schedule_ID", "dbo.Schedule");
            DropIndex("dbo.Task", new[] { "Schedule_ID" });
            DropIndex("dbo.Schedule", new[] { "Worker_ID" });
            DropColumn("dbo.Task", "Schedule_ID");
            DropTable("dbo.Schedule");
        }
    }
}
