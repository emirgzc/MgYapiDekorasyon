namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdateslidertexttitle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sliders", "Title", c => c.String(maxLength: 350));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sliders", "Title", c => c.String(maxLength: 100));
        }
    }
}
