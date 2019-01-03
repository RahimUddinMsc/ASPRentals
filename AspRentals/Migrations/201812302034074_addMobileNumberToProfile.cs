namespace AspRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMobileNumberToProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MobileNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MobileNumber");
        }
    }
}
