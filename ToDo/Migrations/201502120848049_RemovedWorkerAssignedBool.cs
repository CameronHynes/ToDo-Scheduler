namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedWorkerAssignedBool : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Worker", "Assigned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Worker", "Assigned", c => c.Boolean(nullable: false));
        }
    }
}
