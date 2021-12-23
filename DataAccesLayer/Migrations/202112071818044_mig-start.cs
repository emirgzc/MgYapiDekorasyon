namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migstart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        MissionTitle = c.String(maxLength: 100),
                        MissionDesc = c.String(maxLength: 500),
                        VisionTitle = c.String(maxLength: 100),
                        VisionDesc = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ConID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Surname = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        Subject = c.String(maxLength: 100),
                        Message = c.String(maxLength: 1000),
                        DateMes = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ConID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Location = c.String(maxLength: 25),
                        YearCompleted = c.Int(nullable: false),
                        Image = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesId = c.Int(nullable: false, identity: true),
                        ServiceTitle = c.String(maxLength: 100),
                        ServiceDesc = c.String(maxLength: 1000),
                        ServiceImage = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ServicesId);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        City = c.String(maxLength: 20),
                        Country = c.String(maxLength: 20),
                        Address = c.String(maxLength: 20),
                        Phone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        Facebook = c.String(maxLength: 100),
                        Instagram = c.String(maxLength: 100),
                        Copyright = c.String(maxLength: 100),
                        Map = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.SettingId);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        Image = c.String(maxLength: 100),
                        Title = c.String(maxLength: 100),
                        Desc = c.String(maxLength: 250),
                        ButonWay = c.String(maxLength: 10),
                        ButonTitle = c.String(maxLength: 10),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SliderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
            DropTable("dbo.Settings");
            DropTable("dbo.Services");
            DropTable("dbo.Projects");
            DropTable("dbo.Contacts");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
        }
    }
}
