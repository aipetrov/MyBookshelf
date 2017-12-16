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
    /// Логика взаимодействия для InformationAboutBooksPage.xaml
    /// </summary>
    public partial class InformationAboutBooksPage : Page
    {
        Book book;
        Repository repository = new Repository();

        public InformationAboutBooksPage(Book _book, Repository _repository)
        {
            InitializeComponent();
            book = _book;
            repository = _repository;
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void book_review_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
