namespace Vidly_learn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthOfCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birth");
        }
    }
}
