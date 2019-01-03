namespace AspRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedMovieModelWithNumberAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Int(nullable: false));
            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
