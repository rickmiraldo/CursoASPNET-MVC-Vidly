namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'98e03baf-1d42-4aea-b493-1cf817dc4679', N'guest@vidly.com', 0, N'AIcH6fVRD78niRmpXz1Gq9O7j50VeNcCRpMRR6j2UQCkTwzYUR6KKpPf9JdWEY/8Fw==', N'21ee3790-6d9a-46d2-8edb-ad3176c37c79', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd79964c2-d7cb-42f1-8dfb-ccf400312934', N'admin@vidly.com', 0, N'ACXocX3sjSLYul19EbKJrXCjZ3eT/7QsBRArwBLj1SGcZ2ECVopFwP35ICIKkxqFtw==', N'fcd8e9b0-f235-49ff-9bdd-9dc43b0e4f19', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6f531d27-17f0-4270-8626-e5f1abadfb61', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd79964c2-d7cb-42f1-8dfb-ccf400312934', N'6f531d27-17f0-4270-8626-e5f1abadfb61')
");
        }
        
        public override void Down()
        {
        }
    }
}
