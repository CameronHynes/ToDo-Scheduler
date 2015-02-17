namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkerAssignedPropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Worker", "Assigned", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Worker", "Assigned");
        }
    }
}
