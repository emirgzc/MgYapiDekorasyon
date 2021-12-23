namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaboutupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "MissionDesc", c => c.String());
            AlterColumn("dbo.Abouts", "VisionDesc", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "VisionDesc", c => c.String(maxLength: 500));
            AlterColumn("dbo.Abouts", "MissionDesc", c => c.String(maxLength: 500));
        }
    }
}
