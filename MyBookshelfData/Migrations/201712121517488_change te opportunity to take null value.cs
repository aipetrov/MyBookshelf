namespace MyBookshelfData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeteopportunitytotakenullvalue : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Reviews", "User_Id", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "Book_Id" });
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Genre", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Login", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "Comment", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "Book_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "User_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "Book_Id");
            CreateIndex("dbo.Reviews", "User_Id");
            AddForeignKey("dbo.Reviews", "Book_Id", "dbo.Books", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Reviews", "Book_Id", "dbo.Books");
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            DropIndex("dbo.Reviews", new[] { "Book_Id" });
            AlterColumn("dbo.Reviews", "User_Id", c => c.Int());
            AlterColumn("dbo.Reviews", "Book_Id", c => c.Int());
            AlterColumn("dbo.Reviews", "Comment", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Login", c => c.String());
            AlterColumn("dbo.Books", "Description", c => c.String());
            AlterColumn("dbo.Books", "Genre", c => c.String());
            AlterColumn("dbo.Books", "Author", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
            CreateIndex("dbo.Reviews", "User_Id");
            CreateIndex("dbo.Reviews", "Book_Id");
            AddForeignKey("dbo.Reviews", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Reviews", "Book_Id", "dbo.Books", "Id");
        }
    }
}
