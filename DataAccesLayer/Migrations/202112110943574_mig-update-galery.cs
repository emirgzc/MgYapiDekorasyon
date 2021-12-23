namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdategalery : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "Title");
            DropColumn("dbo.Projects", "Desc");
            DropColumn("dbo.Projects", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "Location", c => c.String(maxLength: 25));
            AddColumn("dbo.Projects", "Desc", c => c.String(maxLength: 1500));
            AddColumn("dbo.Projects", "Title", c => c.String(maxLength: 100));
        }
    }
}
