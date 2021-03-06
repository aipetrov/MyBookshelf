﻿using MyBookshelfData;
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
            textblock_book.Text = book.Title;
            ShowReviews(new Context());
        }

        public void ShowReviews(Context context)
        {
            list_reviews.ItemsSource = repository.GetReviews(book);
        }

        private void edit_review_Click(object sender, RoutedEventArgs e)
        {
            repository.ContextUpdated += ShowReviews;
            NavigationService.Navigate(new ReviewEditingPage(list_reviews.SelectedItem as Review, repository));
        }

        private void list_reviews_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_reviews.SelectedItem!=null)
            {
                if (repository.ReviewIsYours(list_reviews.SelectedItem as Review))
                {
                    edit_review.IsEnabled = true;
                    delete_review.IsEnabled = true;
                }
            }
        }

        private void delete_review_Click(object sender, RoutedEventArgs e)
        {
            repository.ContextUpdated += ShowReviews;
            repository.DeleteReview(list_reviews.SelectedItem as Review);
        }

        private void send_review_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(write_review.Text))
                {
                    repository.ContextUpdated += ShowReviews;
                    repository.AddNewReview(book, int.Parse(rating_combobox.Text), write_review.Text);
                    MessageBox.Show("Your review is successfuly sent.", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    write_review.Clear();
                    rating_combobox.Text=null;
                }
                else
                {
                    MessageBox.Show("Write a comment.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
            catch
            {
                MessageBox.Show("Fill in the gaps correctly.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
