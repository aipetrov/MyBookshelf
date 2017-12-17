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
            try
            {
                //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Books', RESEED , 0);");
                //context.Database.ExecuteSqlCommand("DBCC CHEKIDENT('Reviews', RESEED , 0);");
                //context.Database.ExecuteSqlCommand("DBCC CHEKIDENT('Users', RESEED , 0);");

                context.Books.RemoveRange(context.Books);
                context.Reviews.RemoveRange(context.Reviews);
                context.Users.RemoveRange(context.Users);
                context.UserBooks.RemoveRange(context.UserBooks);
                context.SaveChanges();

                string BooksJson = File.ReadAllText(@"C:\Users\Влада\Desktop\MyBookshelf-master (1)\MyBookshelf-master\books.json");
                var BooksToAdd = JsonConvert.DeserializeObject<List<Book>>(BooksJson);
                BooksToAdd.ForEach(item => context.Books.Add(item));
                context.SaveChanges();

                string ReviewsJson = File.ReadAllText(@"C:\Users\Влада\Desktop\MyBookshelf-master (1)\MyBookshelf-master\reviews.json");
                var ReviewsToAdd = JsonConvert.DeserializeObject<List<Review>>(ReviewsJson);
                ReviewsToAdd.ForEach(item => context.Reviews.Add(item));
                context.SaveChanges();

                string UsersJson = File.ReadAllText(@"C:\Users\Влада\Desktop\MyBookshelf-master (1)\MyBookshelf-master\users.json");
                var UsersToAdd = JsonConvert.DeserializeObject<List<User>>(UsersJson);
                UsersToAdd.ForEach(item => context.Users.Add(item));
                context.SaveChanges();

                string UserBooksJson = File.ReadAllText(@"C:\Users\Влада\Desktop\MyBookshelf-master (1)\MyBookshelf-master\userbooks.json");
                var UserBooksToAdd = JsonConvert.DeserializeObject<List<ReadBook>>(UserBooksJson);
                UserBooksToAdd.ForEach(item => context.UserBooks.Add(item));
                context.SaveChanges();
            }
            catch(Exception er)
            {
                File.WriteAllText(@"C:\Users\Влада\Desktop\MyBookshelf-master (1)\MyBookshelf-master\error.txt", JsonConvert.SerializeObject(er));
                throw er;
            }
        }
    }
}
