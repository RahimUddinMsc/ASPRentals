namespace AspRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRoleAndUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8d030150-ddb2-4fb4-bced-7b68793272d7', N'guest@rentals.com', 0, N'ADmi46W8q7VMD7zpyBhPmUquFxV2wAYArMjHj2bH2cSXpBi5NKiP8y5BmYbzZwydjA==', N'9910cdd9-2d1f-4b89-9373-d4fd0d46c9e5', NULL, 0, 0, NULL, 1, 0, N'guest@rentals.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd757b039-b231-4066-93ee-bf7b13fa459c', N'manage@rentals.com', 0, N'AAFRkEqITcY8hrJfOd8ofzwZDgGDOK0dGPDo5IM8Ej1okhUDOX2ZFldUVNjDO9WSfQ==', N'68d4d299-117e-4755-a9d7-87a4c950c537', NULL, 0, 0, NULL, 1, 0, N'manage@rentals.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'94b71904-9058-424a-9c9e-9de4cb9f5006', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd757b039-b231-4066-93ee-bf7b13fa459c', N'94b71904-9058-424a-9c9e-9de4cb9f5006')                
            ");
        }
        
        public override void Down()
        {
        }
    }
}
