using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookshelfData
{
    public class Repository
    {
        public User AuthorisedUser { get; set; }

        public Action<Context> ContextUpdated;

        public Action<List<Book>> ListBookUpdated;

        Book book;

        public Repository()
        {

        }

        public Repository(Book _book, User user)
        {
            book = _book;
            AuthorisedUser = user;
        }

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
            var readBooks = context.Books.Include("Readers").Where(x => x.Readers.FirstOrDefault(k => k.Id==AuthorisedUser.Id)!=null).ToList();
            context.Dispose();
            return readBooks;            
        }

        public void MarkBookAsRead()
        {
            Context context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Id == AuthorisedUser.Id);
            context.Books.Include("Readers").FirstOrDefault(x => x.Id == book.Id).Readers.Add(user);
            context.SaveChanges();
            ContextUpdated?.Invoke(context);
            ListBookUpdated?.Invoke(GetReadBooks());
            context.Dispose();            
        }

        public void DeleteBookFromRead()
        {
            Context context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Id == AuthorisedUser.Id);
            context.Books.Include("Readers").FirstOrDefault(x => x.Id == book.Id).Readers.Remove(user);
            context.SaveChanges();
            ContextUpdated?.Invoke(context);
            context.Dispose();            
        }

        public bool BookIsRead(Book book)
        {
            Context context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Id == AuthorisedUser.Id);
            var readBook = context.Books.Include("Readers").FirstOrDefault(x => x.Readers.FirstOrDefault(y => y.Id==user.Id)!=null && x.Id==book.Id);            
            if (readBook != null)
            {
                context.Dispose();
                return true;
            }
            else
            {
                context.Dispose();
                return false;
            }
        }

        public void AddNewReview(Book book, int rating, string comment)
        {
            Context context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Id == AuthorisedUser.Id);
            var revBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Reviews.Add(new Review { User = user, Book = revBook, Comment = comment, Rating = rating, DateTime = DateTime.Now });
            context.SaveChanges();
            context.Dispose();
            ContextUpdated?.Invoke(context);
        }

        public void DeleteReview(Review review)
        {
            Context context = new Context();
            var reviews = context.Reviews.Remove(context.Reviews.FirstOrDefault(x => x.Id==review.Id));
            context.SaveChanges();
            context.Dispose();
            ContextUpdated?.Invoke(context);
        }

        public void EditReview(Review review, int rating, string comment)
        {
            Context context = new Context();
            var foundReview = context.Reviews.FirstOrDefault(x => x.Id == review.Id);
            foundReview.Rating = rating;
            foundReview.Comment = comment;
            context.SaveChanges();
            context.Dispose();
            ContextUpdated?.Invoke(context);
        }

        public bool ReviewIsYours(Review review)
        {
            Context context = new Context();
            Review yourReview = context.Reviews.FirstOrDefault(x => x.Id == review.Id && x.User.Id==AuthorisedUser.Id);
            if (yourReview != null)
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
            ContextUpdated?.Invoke(context);
        }

        public List<Book> GetRecommendedBooks()
        {
            Context context = new Context();
            var booksOfUser = context.Books.Where(x => x.Readers.FirstOrDefault(z => z.Id == AuthorisedUser.Id)!=null);
            
            var recommendedBooks = new List<Book>();
            foreach (var book in booksOfUser)
            {
                var similarBooks = context.Books.Where(x => x.Genre == book.Genre || x.Author == book.Author).Except(booksOfUser).ToList();
                foreach (var similarBook in similarBooks)  
                {
                    recommendedBooks.Add(similarBook);
                }
            }
            context.Dispose();
            var distRecommendedBooks = recommendedBooks.Distinct().ToList();
            
            return distRecommendedBooks;
        }

        public List<Review> GetReviews(Book book)
        {
            Context context = new Context();
            var reviews = context.Reviews.Include("User").Where(x => x.Book.Id == book.Id).ToList();
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

        public string GetAuthor()
        {
            Context context = new Context();
            var foundBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Dispose();
            return foundBook.Author;
        }

        public string GetAuthor(Book book)
        {
            Context context = new Context();
            var foundBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Dispose();
            return foundBook.Author;
        }

        public string GetTitle()
        {
            Context context = new Context();
            var foundBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Dispose();
            return foundBook.Title;
        }

        public string GetGenre()
        {
            Context context = new Context();
            var foundBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Dispose();
            return foundBook.Genre;
        }

        public string GetImagePath()
        {
            Context context = new Context();
            var foundBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Dispose();
            return foundBook.ImagePath;
        }

        public string GetDescription()
        {
            Context context = new Context();
            var foundBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Dispose();
            return foundBook.Description;
        }

        public Book GetBook()
        {
            Context context = new Context();
            var foundBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
            context.Dispose();
            return foundBook;
        }

        GoogleService googleService = new GoogleService();

        public async void Browse(string authorName)
        {
            var results = await googleService.GetResults(authorName);
            Process.Start(results[0].Url);
        }
    }
}
