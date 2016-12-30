namespace Vidly_learn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you Go' WHERE Id = '1'");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = '2'");
            Sql("UPDATE MembershipTypes SET Name = 'Three-Monthly' WHERE Id = '3'");
            Sql("UPDATE MembershipTypes SET Name = 'Year' WHERE Id = '4'");
        }
        
        public override void Down()
        {
        }
    }
}
