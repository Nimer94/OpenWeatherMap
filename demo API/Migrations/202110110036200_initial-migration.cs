namespace demo_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryCode = c.String(),
                        MainID = c.Int(nullable: false),
                        WeatherID = c.Int(nullable: false),
                        WindID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityID)
                .ForeignKey("dbo.Mains", t => t.MainID, cascadeDelete: true)
                .ForeignKey("dbo.Weathers", t => t.WeatherID, cascadeDelete: true)
                .ForeignKey("dbo.Winds", t => t.WindID, cascadeDelete: true)
                .Index(t => t.MainID)
                .Index(t => t.WeatherID)
                .Index(t => t.WindID);
            
            CreateTable(
                "dbo.Mains",
                c => new
                    {
                        MainID = c.Int(nullable: false, identity: true),
                        CurrentTemperature = c.Double(nullable: false),
                        MinimumTemperature = c.Double(nullable: false),
                        MaximumTemperature = c.Double(nullable: false),
                        Humidity = c.Int(nullable: false),
                        AirPressure = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MainID);
            
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        WeatherID = c.Int(nullable: false, identity: true),
                        WeatherIconImg = c.String(),
                        Cloudcovercondition = c.String(),
                    })
                .PrimaryKey(t => t.WeatherID);
            
            CreateTable(
                "dbo.Winds",
                c => new
                    {
                        WindID = c.Int(nullable: false, identity: true),
                        WindSpeed = c.Double(nullable: false),
                        WindDirection = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WindID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "WindID", "dbo.Winds");
            DropForeignKey("dbo.Cities", "WeatherID", "dbo.Weathers");
            DropForeignKey("dbo.Cities", "MainID", "dbo.Mains");
            DropIndex("dbo.Cities", new[] { "WindID" });
            DropIndex("dbo.Cities", new[] { "WeatherID" });
            DropIndex("dbo.Cities", new[] { "MainID" });
            DropTable("dbo.Winds");
            DropTable("dbo.Weathers");
            DropTable("dbo.Mains");
            DropTable("dbo.Cities");
        }
    }
}
