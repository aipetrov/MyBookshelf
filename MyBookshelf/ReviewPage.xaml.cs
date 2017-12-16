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
    /// Логика взаимодействия для ReviewPage.xaml
    /// </summary>
    public partial class ReviewPage : Page
    {
        Book book;
        Repository repository;

        public ReviewPage(Book _book, Repository _repository)
        {
            InitializeComponent();
            book = _book;
            repository = _repository;
            list_reviews.ItemsSource = repository.GetReviews(book);
            textblock_book.Text = book.Title;
        }

        private void edit_review_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReviewEditingPage(list_reviews.SelectedItem as Review, repository));
        }

        private void list_reviews_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (repository.ReviewIsYours(list_reviews.SelectedItem as Review))
            {
                edit_review.IsEnabled = true;
                delete_review.IsEnabled = true;
            }
        }

        private void delete_review_Click(object sender, RoutedEventArgs e)
        {
            repository.DeleteReview(list_reviews.SelectedItem as Review);
        }

        private void send_review_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                repository.AddNewReview(book, int.Parse(rating_combobox.Text), write_review.Text);
                MessageBox.Show("Your review is successfuly sent.", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch
            {
                MessageBox.Show("Fill in the gaps correctly.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void write_review_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(write_review.Text))
            {
                send_review.IsEnabled = true;
            }
            else
            {
                send_review.IsEnabled = false;
            }
        }
    }
}
