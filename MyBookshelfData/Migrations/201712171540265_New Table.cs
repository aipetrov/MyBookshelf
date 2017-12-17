namespace MyBookshelfData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReadBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Book_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReadBooks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ReadBooks", "Book_Id", "dbo.Books");
            DropIndex("dbo.ReadBooks", new[] { "User_Id" });
            DropIndex("dbo.ReadBooks", new[] { "Book_Id" });
            DropTable("dbo.ReadBooks");
        }
    }
}
