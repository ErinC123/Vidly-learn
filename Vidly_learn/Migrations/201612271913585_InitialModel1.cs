namespace Vidly_learn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genere_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genere_Id" });
            DropColumn("dbo.Customers", "Birth");
            DropColumn("dbo.MembershipTypes", "Name");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberinStock = c.Int(nullable: false),
                        GenreId = c.Byte(nullable: false),
                        Genere_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Birth", c => c.DateTime());
            CreateIndex("dbo.Movies", "Genere_Id");
            AddForeignKey("dbo.Movies", "Genere_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
