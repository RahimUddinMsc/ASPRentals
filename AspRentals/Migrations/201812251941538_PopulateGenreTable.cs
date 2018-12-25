namespace AspRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
           // Sql("SET IDENTITY_INSERT tbl_content ON");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            //Sql("SET IDENTITY_INSERT tbl_content OFF");
            // Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountedRate) VALUES (1,0,0,0)");
        }
        
        public override void Down()
        {
        }
    }
}
