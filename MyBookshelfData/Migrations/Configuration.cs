namespace MyBookshelfData.Migrations
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyBookshelfData.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyBookshelfData.Context";
        }
        Random rand = new Random();

        protected override void Seed(MyBookshelfData.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Books', RESEED , 0);");
            context.Database.ExecuteSqlCommand("DBCC CHEKIDENT('Reviews' , RESEED , 0);");
            context.Database.ExecuteSqlCommand("DBCC CHEKIDENT('Users' , RESEED , 0);");

            context.Books.RemoveRange(context.Books);
            context.Reviews.RemoveRange(context.Reviews);
            context.Users.RemoveRange(context.Users);            
            context.SaveChanges();

            string BooksJson = File.ReadAllText("Books.json");
            var BooksToAdd = JsonConvert.DeserializeObject<List<Book>>(BooksJson);
            context.SaveChanges();

            string ReviewsJson = File.ReadAllText("Reviews.json");
            var ReviewsToAdd = JsonConvert.DeserializeObject<List<Review>>(ReviewsJson);
            context.SaveChanges();

            string UsersJson = File.ReadAllText("Users.json");
            var UsersToAdd = JsonConvert.DeserializeObject<List<User>>(UsersJson);
            context.SaveChanges();

            string UserBooksJson = File.ReadAllText("UserBooks.json");
            var UserBooksToAdd = JsonConvert.DeserializeObject<List<ReadBooks>>(UserBooks);*/
        }
    }
}
