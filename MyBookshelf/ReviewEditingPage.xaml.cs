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
    /// Логика взаимодействия для ReviewEditingPage.xaml
    /// </summary>
    public partial class ReviewEditingPage : Page
    {
        Repository repository = new Repository();
        Review review = new Review();

        public ReviewEditingPage(Review _review, Repository _repository)
        {
            InitializeComponent();
            review = _review;
            repository = _repository;
            new_rating.Text = repository.GetReviewRating(review).ToString();
            new_comment.Text = repository.GetReviewComment(review);
        }

        private void save_review_Click(object sender, RoutedEventArgs e)
        {
            repository.EditReview(review, int.Parse(new_rating.Text), new_comment.Text);
        }
    }
}
