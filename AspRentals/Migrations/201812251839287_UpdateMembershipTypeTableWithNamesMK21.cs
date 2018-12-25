namespace AspRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeTableWithNamesMK21 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET NAME = 'Pay as You Go' WHERE ID = 1");
        }
        
        public override void Down()
        {
        }
    }
}
