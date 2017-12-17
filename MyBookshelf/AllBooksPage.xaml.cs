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
using MyBookshelfData;

namespace MyBookshelf
{
    /// <summary>
    /// Логика взаимодействия для AllBooksPage.xaml
    /// </summary>
    public partial class AllBooksPage : Page
    {
        Repository repository = new Repository();

        public AllBooksPage(Repository _repository)
        {
            InitializeComponent();
            repository = _repository;
            all_books.ItemsSource = repository.GetBooks();
        }

        private void all_books_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new InformationAboutBooksPage(all_books.SelectedItem as Book, repository));
        }
    }
}
