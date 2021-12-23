namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addprojectdesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Desc", c => c.String(maxLength: 1500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Desc");
        }
    }
}
