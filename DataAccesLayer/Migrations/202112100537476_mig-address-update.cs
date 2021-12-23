namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddressupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Settings", "Address", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "Address", c => c.String(maxLength: 20));
        }
    }
}
