using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookshelfData
{
    public class Repository
    {
        public User AuthorisedUser { get; set; }

        public bool SignedIn(string login, string password)
        {
            Context context = new Context();
            var authorisedUser = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            context.Dispose();
            if (authorisedUser != null)
            {
                AuthorisedUser = authorisedUser as User;
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool UserExists(string login)
        {
            Context context = new Context();

            var user = context.Users.FirstOrDefault(u => u.Login == login);
            context.Dispose();
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SignUp(string login, string password, string name, DateTime birth)
        {
            Context context = new Context();
            var users = context.Users.Add(new User { Login = login, Password = password, Name = name, Birth = birth });
            context.SaveChanges();
            context.Dispose();
        }

        public List<Book> GetBooks()
        {
            Context context = new Context();
            var books = context.Books.ToList();
            context.Dispose();       
            return books;            
        }

        public List<Book> GetReadBooks()
        {
            Context context = new Context();
            var readBooks = context.Books.Where(x => x.Readers.FirstOrDefault(k => k.Id==AuthorisedUser.Id)!=null).ToList();
            context.Dispose();
            return readBooks;            
        }

        public void MarkBookAsRead(Book book)
        {
            Context context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Id == AuthorisedUser.Id);
            context.Books.Include("Readers").FirstOrDefault(x => x.Id == book.Id).Readers.Add(user);
            context.SaveChanges();
            context.Dispose();
        }

        public void DeleteBookFromRead(Book book)
        {
            Context context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Id == AuthorisedUser.Id);
            context.Books.Include("Readers").FirstOrDefault(x => x.Id == book.Id).Readers.Remove(user);
            context.SaveChanges();
            context.Dispose();
        }

        public bool BookIsRead(Book book)
        {
            Context context = new Context();
            var reader = context.Books.Where(x => x.Readers.Contains(AuthorisedUser));
            context.Dispose();
            if (reader != null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public void AddNewReview(Book book, int rating, string comment)
        {
            Context context = new Context();
            var reviews = context.Reviews.ToList();
            reviews.Add(new Review { User = AuthorisedUser, Book = book, Comment = comment, Rating = rating, DateTime = DateTime.Now });
            context.SaveChanges();
            context.Dispose();
        }

        public void DeleteReview(Review review)
        {
            Context context = new Context();
            var reviews = context.Reviews.ToList();
            reviews.Remove(review);
            context.SaveChanges();
            context.Dispose();
        }

        public void EditReview(Review review, int rating, string comment)
        {
            Context context = new Context();
            var foundReview = context.Reviews.FirstOrDefault(x => x.Id == review.Id);
            foundReview.Rating = rating;
            foundReview.Comment = comment;
            context.SaveChanges();
            context.Dispose();
        }

        public bool ReviewIsYours(Review review)
        {
            Context context = new Context();
            var reviews = context.Reviews.Where(x => x.User == AuthorisedUser);
            context.Dispose();
            if (reviews.FirstOrDefault(x => x.Id == review.Id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculateRating(Book book)
        {
            Context context = new Context();
            var reviews = context.Reviews.Where(x => x.Book.Id == book.Id).ToList();
            context.Dispose();
            int sumOfRatings = 0;
            int k = 0;
            foreach (var rev in reviews)
            {
                sumOfRatings += rev.Rating;
                k++;
            }

            double rating = 0;

            if (k > 0)
            { rating = sumOfRatings / k; }

            return Math.Round(rating, 2);

        }       

        public void EditProfile(string name, string password, DateTime birth)
        {
            Context context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Id == AuthorisedUser.Id);
            user.Name = name;
            user.Password = password;
            user.Birth = birth;
            AuthorisedUser = user;
            context.SaveChanges();
            context.Dispose();
        }

        public List<Book> GetRecommendedBooks()
        {
            Context context = new Context();
            var booksOfUser = context.Books.Where(x => x.Readers.FirstOrDefault(z => z.Id == AuthorisedUser.Id)!=null);
            context.Dispose();
            var recommendedBooks = new List<Book>();
            foreach (var book in booksOfUser)
            {
                var similarBooks = context.Books.Where(x => x.Genre == book.Genre || x.Author == book.Author).ToList();
                foreach (var similarBook in similarBooks)
                {
                    recommendedBooks.Add(similarBook);
                }
            }

            var distRecommendedBooks = recommendedBooks.Distinct().ToList();

            return distRecommendedBooks;
        }

        public List<Review> GetReviews(Book book)
        {
            Context context = new Context();
            var reviews = context.Reviews.Where(x => x.Book.Id == book.Id).ToList();
            context.Dispose();
            return reviews;
        }

        public string GetReviewComment(Review review)
        {
            Context context = new Context();
            var foundReview = context.Reviews.FirstOrDefault(x => x.Id == review.Id);
            context.Dispose();
            return foundReview.Comment;
        }

        public int GetReviewRating(Review review)
        {
            Context context = new Context();
            var foundReview = context.Reviews.FirstOrDefault(x => x.Id == review.Id);
            context.Dispose();
            return foundReview.Rating;
        }
    }
}
