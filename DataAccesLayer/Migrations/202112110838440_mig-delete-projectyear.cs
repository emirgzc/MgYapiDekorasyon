namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migdeleteprojectyear : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "YearCompleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "YearCompleted", c => c.Int(nullable: false));
        }
    }
}
