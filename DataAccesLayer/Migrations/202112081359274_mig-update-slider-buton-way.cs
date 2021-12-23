namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdatesliderbutonway : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sliders", "ButonWay", c => c.String(maxLength: 30));
            AlterColumn("dbo.Sliders", "ButonTitle", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sliders", "ButonTitle", c => c.String(maxLength: 10));
            AlterColumn("dbo.Sliders", "ButonWay", c => c.String(maxLength: 10));
        }
    }
}
