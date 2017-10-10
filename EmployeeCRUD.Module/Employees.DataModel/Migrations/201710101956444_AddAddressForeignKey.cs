namespace Employees.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressForeignKey : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "AddressId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Employees", "AddressId");
            AddForeignKey("dbo.Employees", "AddressId", "dbo.Addresses", "AddressId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Employees", new[] { "AddressId" });
            AlterColumn("dbo.Employees", "AddressId", c => c.String());
        }
    }
}
