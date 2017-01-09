namespace Vidly_learn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8095fd08-01f4-4a28-b090-52eb51b1d35d', N'admin@vidly.com', 0, N'AHb6d5J8wz+Yv4nuAtj3yEMBatLcRtvckGD/gRRLFWbb2rBm7bQgQOphbdYV+tlrSQ==', N'cfc9767e-02a6-4124-9554-d33072604487', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ec99dd60-aa88-4ed4-8066-ae550dbb58b9', N'guest@vidly.com', 0, N'AK/m3fOCdNJljguHRy9RUxbjIvOoFm8ugAtVLgZdL9hlH70QX6pAMNgymn4CPD/0qA==', N'c677e593-098f-48cd-b1f7-169ce22c3852', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58b7f0c8-93a1-4853-a70c-2fa6903a6a3f', N'CanManageMovie')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8095fd08-01f4-4a28-b090-52eb51b1d35d', N'58b7f0c8-93a1-4853-a70c-2fa6903a6a3f')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
