namespace EmployeesDemo.DataMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationsToEmployeesDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String());
            AlterColumn("dbo.Cities", "Name", c => c.String());
        }
    }
}
