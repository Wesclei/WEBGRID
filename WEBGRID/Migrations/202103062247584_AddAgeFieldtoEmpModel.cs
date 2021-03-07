namespace WEBGRID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeFieldtoEmpModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Age");
        }
    }
}
