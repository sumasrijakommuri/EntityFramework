namespace Employees.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddress : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Employees");
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.String(nullable: false, maxLength: 128),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            AddColumn("dbo.Employees", "EmployeeId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Employees", "AddressId", c => c.String());
            AddPrimaryKey("dbo.Employees", "EmployeeId");
            DropColumn("dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Employees");
            DropColumn("dbo.Employees", "AddressId");
            DropColumn("dbo.Employees", "EmployeeId");
            DropTable("dbo.Addresses");
            AddPrimaryKey("dbo.Employees", "Id");
        }
    }
}
