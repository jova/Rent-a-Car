namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbupdatedotnetframework : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Address = c.String(),
                        VehiclesNumber = c.Int(nullable: false),
                        Point = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "public.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        TCNumber = c.Int(nullable: false),
                        Company_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("public.Companies", t => t.Company_ID)
                .Index(t => t.Company_ID);
            
            CreateTable(
                "public.Rentalinformations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RentalRange = c.DateTime(nullable: false),
                        StartKm = c.Int(nullable: false),
                        LastKm = c.Int(nullable: false),
                        Payment = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Customer_ID = c.Int(),
                        VehicleInformation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("public.Customers", t => t.Customer_ID)
                .ForeignKey("public.VehicleInformations", t => t.VehicleInformation_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.VehicleInformation_ID);
            
            CreateTable(
                "public.VehicleInformations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Model = c.String(),
                        Address = c.String(),
                        LicenseAge = c.Int(nullable: false),
                        MinLicenseAge = c.Int(nullable: false),
                        DailyBorderKm = c.Int(nullable: false),
                        Airbag = c.Boolean(nullable: false),
                        BaggageVolume = c.Int(nullable: false),
                        SeatingCapacity = c.Int(nullable: false),
                        DailyRentalPrice = c.Int(nullable: false),
                        Company_ID = c.Int(),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("public.Companies", t => t.Company_ID)
                .ForeignKey("public.Customers", t => t.Customer_ID)
                .Index(t => t.Company_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "public.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "public.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        Role_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("public.Roles", t => t.Role_ID)
                .Index(t => t.Role_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Users", "Role_ID", "public.Roles");
            DropForeignKey("public.Rentalinformations", "VehicleInformation_ID", "public.VehicleInformations");
            DropForeignKey("public.VehicleInformations", "Customer_ID", "public.Customers");
            DropForeignKey("public.VehicleInformations", "Company_ID", "public.Companies");
            DropForeignKey("public.Rentalinformations", "Customer_ID", "public.Customers");
            DropForeignKey("public.Customers", "Company_ID", "public.Companies");
            DropIndex("public.Users", new[] { "Role_ID" });
            DropIndex("public.VehicleInformations", new[] { "Customer_ID" });
            DropIndex("public.VehicleInformations", new[] { "Company_ID" });
            DropIndex("public.Rentalinformations", new[] { "VehicleInformation_ID" });
            DropIndex("public.Rentalinformations", new[] { "Customer_ID" });
            DropIndex("public.Customers", new[] { "Company_ID" });
            DropTable("public.Users");
            DropTable("public.Roles");
            DropTable("public.VehicleInformations");
            DropTable("public.Rentalinformations");
            DropTable("public.Customers");
            DropTable("public.Companies");
        }
    }
}
