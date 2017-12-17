using MyBookshelfData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyBookshelf
{
    /// <summary>
    /// Логика взаимодействия для InformationAboutBooksPage.xaml
    /// </summary>
    public partial class InformationAboutBooksPage : Page
    {
        Repository repository;
        Book book;

        public InformationAboutBooksPage(Book _book, Repository _repository)
        {
            InitializeComponent();
            book = _book;
            repository = _repository;
            Repository r = new Repository(book, repository.AuthorisedUser);
            text_author.Text = "Author: " + r.GetAuthor();
            text_booktitle.Text = "Title: " + r.GetTitle();
            text_genre.Text = "Genre: " + r.GetGenre();
            text_rating.Text = "Rating: " + r.CalculateRating(book);
            book_description.Text=r.GetDescription();

            if (repository.BookIsRead(book))
            {
                button_delete.Visibility = Visibility.Visible;
                button_add.Visibility = Visibility.Hidden;
            }
            else
            {
                button_add.Visibility = Visibility.Visible;
                button_delete.Visibility = Visibility.Hidden;
            }
        }

        private void book_review_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReviewPage(book, repository));
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            Repository r = new Repository(book, repository.AuthorisedUser);
            r.DeleteBookFromRead();
            button_add.Visibility = Visibility.Visible;
            button_delete.Visibility = Visibility.Hidden;
            NavigationService.Navigate(new ProfilePage(repository));
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            Repository r = new Repository(book, repository.AuthorisedUser);
            r.MarkBookAsRead();
            button_delete.Visibility = Visibility.Visible;
            button_add.Visibility = Visibility.Hidden;
            NavigationService.Navigate(new ProfilePage(repository));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            repository.Browse(repository.GetAuthor(book));
        }
    }
}
